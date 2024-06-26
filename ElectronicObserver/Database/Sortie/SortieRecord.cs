﻿using System.Collections.Generic;
using ElectronicObserver.Database.KancolleApi;

namespace ElectronicObserver.Database.Sortie;

public class SortieRecord
{
	public int Id { get; set; }
	public required int Version { get; set; }
	public required int World { get; set; }
	public required int Map { get; set; }
	public List<ApiFile> ApiFiles { get; set; } = [];
	public required SortieFleetData FleetData { get; set; }
	public SortieFleetData? FleetAfterSortieData { get; set; }
	public required SortieMapData MapData { get; set; }
	public CalculatedSortieCost CalculatedSortieCost { get; set; } = new();
}
