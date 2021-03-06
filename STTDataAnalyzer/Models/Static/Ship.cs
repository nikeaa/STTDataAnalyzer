using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class Ship
	{
		[JsonProperty("archetype_id")]
		public int ArchetypeId { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("rarity")]
		public int Rarity { get; set; }

		[JsonProperty("icon")]
		public Icon Icon { get; set; }

		[JsonProperty("flavor")]
		public string Flavor { get; set; }

		[JsonProperty("model")]
		public string Model { get; set; }

		[JsonProperty("max_level")]
		public int MaxLevel { get; set; }

		[JsonProperty("actions")]
		public Action[] Actions { get; set; }

		[JsonProperty("shields")]
		public int Shields { get; set; }

		[JsonProperty("hull")]
		public int Hull { get; set; }

		[JsonProperty("attack")]
		public int Attack { get; set; }

		[JsonProperty("evasion")]
		public int Evasion { get; set; }

		[JsonProperty("accuracy")]
		public int Accuracy { get; set; }

		[JsonProperty("crit_chance")]
		public int CritChance { get; set; }

		[JsonProperty("crit_bonus")]
		public int CritBonus { get; set; }

		[JsonProperty("attacks_per_second")]
		public double AttacksPerSecond { get; set; }

		[JsonProperty("shield_regen")]
		public int ShieldRegen { get; set; }

		[JsonProperty("traits")]
		public string[] Traits { get; set; }

		[JsonProperty("traits_hidden")]
		public string[] TraitsHidden { get; set; }

		[JsonProperty("antimatter")]
		public int Antimatter { get; set; }

		[JsonProperty("traits_named")]
		public string[] TraitsNamed { get; set; }
	}
}