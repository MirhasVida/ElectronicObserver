﻿using ElectronicObserver.Window.Tools.SortieRecordViewer.SortieCostViewer;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace ElectronicObserverCoreTests.SortieCost.YamatoTouch;

#pragma warning disable xUnit1004
public sealed class YamatoTouchCostTests : SortieCostTestBase
{
	protected override string RelativePath => Path.Join("SortieCost", "YamatoTouch");

	[Theory(DisplayName = "no fleet after sortie data")]
	[InlineData("YamatoTouchCostTest01")]
	[InlineData("YamatoTouchCostTest02")]
	[InlineData("YamatoTouchCostTest03")]
	[InlineData("YamatoTouchCostTest04")]
	[InlineData("YamatoTouchCostTest05")]
	[InlineData("YamatoTouchCostTest06")]
	[InlineData("YamatoTouchCostTest07")]
	[InlineData("YamatoTouchCostTest08")]
	[InlineData("YamatoTouchCostTest09")]
	[InlineData("YamatoTouchCostTest10")]
	[InlineData("YamatoTouchCostTest11")]
	[InlineData("YamatoTouchCostTest12")]
	[InlineData("YamatoTouchCostTest13")]
	[InlineData("YamatoTouchCostTest14")]
	[InlineData("YamatoTouchCostTest15")]
	[InlineData("YamatoTouchCostTest16")]
	[InlineData("YamatoTouchCostTest17")]
	[InlineData("YamatoTouchCostTest18")]
	public override async Task SortieCostTest0(string testFilePrefix)
	{
		await base.SortieCostTest0(testFilePrefix);
	}

	[Fact(DisplayName = "2 ships, combined vs combined, night A rank")]
	public async Task YamatoTouchCostTest1()
	{
		List<SortieCostViewModel> sortieCosts = await MakeSortieCosts("YamatoTouchCostTest01", true);

		Assert.Single(sortieCosts);

		SortieCostModel mainResupplyCost = new() { Fuel = 442, Ammo = 464, Bauxite = 465 };
		SortieCostModel escortResupplyCost = new() { Fuel = 82, Ammo = 84 };

		Assert.Equal(mainResupplyCost + escortResupplyCost, sortieCosts[0].SortieFleetSupplyCost);
	}

	[Fact(DisplayName = "2 ships, combined vs combined, day S rank")]
	public async Task YamatoTouchCostTest2()
	{
		List<SortieCostViewModel> sortieCosts = await MakeSortieCosts("YamatoTouchCostTest02", true);

		Assert.Single(sortieCosts);

		SortieCostModel mainResupplyCost = new() { Fuel = 442, Ammo = 464, Bauxite = 555 };
		SortieCostModel escortResupplyCost = new() { Fuel = 82, Ammo = 84 };

		Assert.Equal(mainResupplyCost + escortResupplyCost, sortieCosts[0].SortieFleetSupplyCost);
	}

	[Fact(DisplayName = "2 ships, combined vs single, night", Skip = "todo")]
	public async Task YamatoTouchCostTest3()
	{
		// todo
		Assert.True(await Task.FromResult(true));
	}

	[Fact(DisplayName = "2 ships, combined vs single, day", Skip = "todo")]
	public async Task YamatoTouchCostTest4()
	{
		// todo
		Assert.True(await Task.FromResult(true));
	}

	[Fact(DisplayName = "2 ships, single vs combined, night", Skip = "todo")]
	public async Task YamatoTouchCostTest5()
	{
		// todo
		Assert.True(await Task.FromResult(true));
	}

	[Fact(DisplayName = "2 ships, single vs combined, day", Skip = "todo")]
	public async Task YamatoTouchCostTest6()
	{
		// todo
		Assert.True(await Task.FromResult(true));
	}

	[Fact(DisplayName = "2 ships, single vs single, night", Skip = "todo")]
	public async Task YamatoTouchCostTest7()
	{
		// todo
		Assert.True(await Task.FromResult(true));
	}

	[Fact(DisplayName = "2 ships, single vs single, day", Skip = "todo")]
	public async Task YamatoTouchCostTest8()
	{
		// todo
		Assert.True(await Task.FromResult(true));
	}

	[Fact(DisplayName = "2 ships, single vs single, night only", Skip = "todo")]
	public async Task YamatoTouchCostTest9()
	{
		// todo
		Assert.True(await Task.FromResult(true));
	}

	[Fact(DisplayName = "3 ships, combined vs combined, night", Skip = "todo")]
	public async Task YamatoTouchCostTest10()
	{
		// todo
		Assert.True(await Task.FromResult(true));
	}

	[Fact(DisplayName = "3 ships, combined vs combined, day", Skip = "todo")]
	public async Task YamatoTouchCostTest11()
	{
		// todo
		Assert.True(await Task.FromResult(true));
	}

	[Fact(DisplayName = "3 ships, combined vs single, night", Skip = "todo")]
	public async Task YamatoTouchCostTest12()
	{
		// todo
		Assert.True(await Task.FromResult(true));
	}

	[Fact(DisplayName = "3 ships, combined vs single, day", Skip = "todo")]
	public async Task YamatoTouchCostTest13()
	{
		// todo
		Assert.True(await Task.FromResult(true));
	}

	[Fact(DisplayName = "3 ships, single vs combined, night", Skip = "todo")]
	public async Task YamatoTouchCostTest14()
	{
		// todo
		Assert.True(await Task.FromResult(true));
	}

	[Fact(DisplayName = "3 ships, single vs combined, day", Skip = "todo")]
	public async Task YamatoTouchCostTest15()
	{
		// todo
		Assert.True(await Task.FromResult(true));
	}

	[Fact(DisplayName = "3 ships, single vs single, night", Skip = "todo")]
	public async Task YamatoTouchCostTest16()
	{
		// todo
		Assert.True(await Task.FromResult(true));
	}

	[Fact(DisplayName = "3 ships, single vs single, day S rank")]
	public async Task YamatoTouchCostTest17()
	{
		List<SortieCostViewModel> sortieCosts = await MakeSortieCosts("YamatoTouchCostTest17", true);

		Assert.Single(sortieCosts);

		SortieCostModel resupplyCost = new() { Fuel = 334, Ammo = 483, Bauxite = 120 };

		Assert.Equal(resupplyCost, sortieCosts[0].SortieFleetSupplyCost);
	}

	[Fact(DisplayName = "3 ships, single vs single, night only", Skip = "todo")]
	public async Task YamatoTouchCostTest18()
	{
		// todo
		Assert.True(await Task.FromResult(true));
	}
}
