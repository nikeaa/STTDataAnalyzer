using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdAbility
	{
		[JsonProperty("condition")]
		public long Condition { get; set; }

		[JsonProperty("type")]
		public long Type { get; set; }

		[JsonProperty("amount")]
		public long Amount { get; set; }
	}
}
