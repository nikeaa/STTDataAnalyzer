using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdShipBattle
	{
		[JsonProperty("accuracy", NullValueHandling = NullValueHandling.Ignore)]
		public long? Accuracy { get; set; }

		[JsonProperty("evasion", NullValueHandling = NullValueHandling.Ignore)]
		public long? Evasion { get; set; }

		[JsonProperty("crit_chance", NullValueHandling = NullValueHandling.Ignore)]
		public long? CritChance { get; set; }

		[JsonProperty("crit_bonus", NullValueHandling = NullValueHandling.Ignore)]
		public long? CritBonus { get; set; }
	}
}
