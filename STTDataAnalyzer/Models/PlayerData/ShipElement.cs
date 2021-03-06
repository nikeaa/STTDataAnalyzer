﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class ShipElement
	{
		[JsonProperty("archetype_id")]
		public long ArchetypeId { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("rarity")]
		public long Rarity { get; set; }

		[JsonProperty("icon")]
		public PdIconClass Icon { get; set; }

		[JsonProperty("flavor")]
		public string Flavor { get; set; }

		[JsonProperty("max_level")]
		public long MaxLevel { get; set; }

		[JsonProperty("actions")]
		public List<PdActionElement> Actions { get; set; }

		[JsonProperty("shields")]
		public long Shields { get; set; }

		[JsonProperty("hull")]
		public long Hull { get; set; }

		[JsonProperty("attack")]
		public long Attack { get; set; }

		[JsonProperty("evasion")]
		public long Evasion { get; set; }

		[JsonProperty("accuracy")]
		public long Accuracy { get; set; }

		[JsonProperty("crit_chance")]
		public long CritChance { get; set; }

		[JsonProperty("crit_bonus")]
		public long CritBonus { get; set; }

		[JsonProperty("attacks_per_second")]
		public double AttacksPerSecond { get; set; }

		[JsonProperty("shield_regen")]
		public long ShieldRegen { get; set; }

		[JsonProperty("traits")]
		public List<string> Traits { get; set; }

		[JsonProperty("traits_hidden")]
		public List<object> TraitsHidden { get; set; }

		[JsonProperty("antimatter")]
		public long Antimatter { get; set; }

		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("level")]
		public long Level { get; set; }

		[JsonProperty("model")]
		public string Model { get; set; }

		[JsonProperty("schematic_gain_cost_next_level")]
		public long SchematicGainCostNextLevel { get; set; }

		[JsonProperty("schematic_id")]
		public long SchematicId { get; set; }

		[JsonProperty("schematic_icon")]
		public PdIconClass SchematicIcon { get; set; }

		[JsonProperty("battle_stations")]
		public List<PdBattleStation> BattleStations { get; set; }
	}
}
