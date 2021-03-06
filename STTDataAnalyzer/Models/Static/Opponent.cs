using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class Opponent
	{

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("ship_icon")]
		public Icon ShipIcon { get; set; }

		[JsonProperty("ship_name")]
		public string ShipName { get; set; }

		[JsonProperty("ship_level")]
		public int ShipLevel { get; set; }

		[JsonProperty("rarity")]
		public int Rarity { get; set; }

		[JsonProperty("shields")]
		public int Shields { get; set; }

		[JsonProperty("hull")]
		public int Hull { get; set; }

		[JsonProperty("evasion")]
		public int Evasion { get; set; }

		[JsonProperty("attack")]
		public int Attack { get; set; }

		[JsonProperty("accuracy")]
		public int Accuracy { get; set; }

		[JsonProperty("crit_chance")]
		public int CritChance { get; set; }

		[JsonProperty("crit_bonus")]
		public int CritBonus { get; set; }

		[JsonProperty("accacks_per_second")]
		public decimal AttacksPerSecond { get; set; }

		[JsonProperty("shield_regen")]
		public int ShieldRegen { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("icon")]
		public Icon Icon { get; set; }
	}
}