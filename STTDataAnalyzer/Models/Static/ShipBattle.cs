using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class ShipBattle
	{
		[JsonProperty("accuracy")]
		public int Accuracy { get; set; }

		[JsonProperty("evasion")]
		public int Evasion { get; set; }

		[JsonProperty("crit_chance")]
		public int CritChance { get; set; }

		[JsonProperty("crit_bonus")]
		public int CritBonus { get; set; }
	}
}
