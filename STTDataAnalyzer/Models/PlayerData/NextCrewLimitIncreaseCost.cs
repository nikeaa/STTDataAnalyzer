using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdNextCrewLimitIncreaseCost
	{
		[JsonProperty("currency")]
		public long Currency { get; set; }

		[JsonProperty("amount")]
		public long Amount { get; set; }
	}
}
