﻿namespace ElectronicObserverTypes.Extensions;
public static class EquipmentCardTypeExtensions
{
	public static string TranslatedName(this EquipmentCardType type) => type switch
	{
		EquipmentCardType.PrimaryArmament => Properties.EquipmentCardType.PrimaryArmament,
		EquipmentCardType.SecondaryArmament => Properties.EquipmentCardType.SecondaryArmament,
		EquipmentCardType.Torpedo => Properties.EquipmentCardType.Torpedo,
		EquipmentCardType.MidgetSubmarine => Properties.EquipmentCardType.MidgetSubmarine,
		EquipmentCardType.CarrierBasedAircraft => Properties.EquipmentCardType.CarrierBasedAircraft,
		EquipmentCardType.AaGun => Properties.EquipmentCardType.AaGun,
		EquipmentCardType.Reconnaissance => Properties.EquipmentCardType.Reconnaissance,
		EquipmentCardType.Radar => Properties.EquipmentCardType.Radar,
		EquipmentCardType.Upgrades => Properties.EquipmentCardType.Upgrades,
		EquipmentCardType.Sonar => Properties.EquipmentCardType.Sonar,
		EquipmentCardType.Daihatsu => Properties.EquipmentCardType.Daihatsu,
		EquipmentCardType.Autogyro => Properties.EquipmentCardType.Autogyro,
		EquipmentCardType.AntiSubmarinePatrol => Properties.EquipmentCardType.AntiSubmarinePatrol,
		EquipmentCardType.ExtensionArmor => Properties.EquipmentCardType.ExtensionArmor,
		EquipmentCardType.Searchlight => Properties.EquipmentCardType.Searchlight,
		EquipmentCardType.Supply => Properties.EquipmentCardType.Supply,
		EquipmentCardType.MachineTools => Properties.EquipmentCardType.MachineTools,
		EquipmentCardType.Flare => Properties.EquipmentCardType.Flare,
		EquipmentCardType.FleetCommand => Properties.EquipmentCardType.FleetCommand,
		EquipmentCardType.MaintenanceTeam => Properties.EquipmentCardType.MaintenanceTeam,
		EquipmentCardType.AaDirector => Properties.EquipmentCardType.AaDirector,
		EquipmentCardType.ApShell => Properties.EquipmentCardType.ApShell,
		EquipmentCardType.RocketArtillery => Properties.EquipmentCardType.RocketArtillery,
		EquipmentCardType.PicketCrew => Properties.EquipmentCardType.PicketCrew,
		EquipmentCardType.AaShell => Properties.EquipmentCardType.AaShell,
		EquipmentCardType.AaRocket => Properties.EquipmentCardType.AaRocket,
		EquipmentCardType.DamageControl => Properties.EquipmentCardType.DamageControl,
		EquipmentCardType.EngineUpgrades => Properties.EquipmentCardType.EngineUpgrades,
		EquipmentCardType.DepthCharge => Properties.EquipmentCardType.DepthCharge,
		EquipmentCardType.FlyingBoat => Properties.EquipmentCardType.FlyingBoat,
		EquipmentCardType.Ration => Properties.EquipmentCardType.Ration,
		EquipmentCardType.Supply2 => Properties.EquipmentCardType.Supply2,
		EquipmentCardType.MultiPurposeSeaplane => Properties.EquipmentCardType.MultiPurposeSeaplane,
		EquipmentCardType.AmphibiousVehicle => Properties.EquipmentCardType.AmphibiousVehicle,
		EquipmentCardType.LandAttacker => Properties.EquipmentCardType.LandAttacker,
		EquipmentCardType.Interceptor => Properties.EquipmentCardType.Interceptor,
		EquipmentCardType.JetFightingBomber => Properties.EquipmentCardType.JetFightingBomber,
		EquipmentCardType.TransportMaterials => Properties.EquipmentCardType.TransportMaterials,
		EquipmentCardType.SubmarineEquipment => Properties.EquipmentCardType.SubmarineEquipment,
		EquipmentCardType.MultiPurposeSeaplane2 => Properties.EquipmentCardType.MultiPurposeSeaplane2,
		EquipmentCardType.Helicopter => Properties.EquipmentCardType.Helicopter,
		EquipmentCardType.DdTank => Properties.EquipmentCardType.DdTank,
		EquipmentCardType.HeavyBomber => Properties.EquipmentCardType.HeavyBomber,
		_ => Properties.EquipmentCardType.Unknown
	};
}