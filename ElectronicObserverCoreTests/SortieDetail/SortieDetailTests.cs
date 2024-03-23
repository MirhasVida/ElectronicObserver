﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using ElectronicObserver.Database;
using ElectronicObserver.Database.Sortie;
using ElectronicObserver.Services;
using ElectronicObserver.Window.Tools.SortieRecordViewer;
using ElectronicObserver.Window.Tools.SortieRecordViewer.Sortie.Node;
using ElectronicObserver.Window.Tools.SortieRecordViewer.SortieDetail;
using ElectronicObserverTypes;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace ElectronicObserverCoreTests.SortieDetail;

public class SortieDetailTests
{
	private static string DirectoryName => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!;
	private static string RelativePath => "SortieDetail";
	private static string BasePath => Path.Join(DirectoryName, RelativePath);

	private static async Task<T> GetDataFromFile<T>(string fileName) where T : new()
	{
		string path = Path.Join(BasePath, fileName);

		if (!File.Exists(path)) return new();

		Stream stream = File.OpenRead(path);
		T? data = await JsonSerializer.DeserializeAsync<T>(stream);

		Assert.NotNull(data);

		return data;
	}

	private static async Task<List<SortieRecordViewModel>> MakeSortieRecords(ElectronicObserverContext db,
		string fileName)
	{
		List<SortieRecord> sortieRecords = await GetDataFromFile<List<SortieRecord>>(fileName);

		await db.AddRangeAsync(sortieRecords);
		await db.SaveChangesAsync();

		List<SortieRecordViewModel> sorties = await db.Sorties
			.Include(s => s.ApiFiles)
			.Select(s => new SortieRecordViewModel(s, s.ApiFiles.Select(f => f.TimeStamp).Min()))
			.ToListAsync();

		return sorties;
	}

	private static async Task<List<SortieDetailViewModel>> MakeSortieDetails(string fileName)
	{
		await using ElectronicObserverContext db = new(true);
		await db.Database.EnsureDeletedAsync();
		await db.Database.EnsureCreatedAsync();

		ToolService toolService = new(new());

		List<SortieRecordViewModel> sortieRecords = await MakeSortieRecords(db, fileName);

		List<SortieDetailViewModel> sortieDetails = sortieRecords
			.Select(r => toolService.GenerateSortieDetailViewModel(db, r.Model))
			.OfType<SortieDetailViewModel>()
			.ToList();

		return sortieDetails;
	}

	[Fact(DisplayName = "Combined fleet vs single fleet - make sure night battle HP results are updated")]
	public async Task SortieDetailTest1()
	{
		List<SortieDetailViewModel> sortieDetails = await MakeSortieDetails("SortieDetailTest1.json");

		Assert.Single(sortieDetails);

		BattleNode battle = (BattleNode)sortieDetails[0].Nodes.Last();

		Assert.NotNull(battle.SecondBattle);

		IShipData zuihouAfterFirstBattle = battle.FirstBattle.FleetsAfterBattle
			.SortieShips()
			.OfType<IShipData>()
			.First(s => s.MasterShip.ShipId is ShipId.ZuihouKaiNiB);

		Assert.Equal(32, zuihouAfterFirstBattle.HPCurrent);

		IShipData zuihouBeforeSecondBattle = battle.SecondBattle.FleetsBeforeBattle
			.SortieShips()
			.OfType<IShipData>()
			.First(s => s.MasterShip.ShipId is ShipId.ZuihouKaiNiB);

		Assert.Equal(32, zuihouBeforeSecondBattle.HPCurrent);
	}
}
