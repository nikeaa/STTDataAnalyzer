namespace STTDataAnalyzer.Models.PlayerData
{
	using Newtonsoft.Json;

	public partial class PdPenalty
	{
		[JsonProperty("type")]
		public long Type { get; set; }

		[JsonProperty("amount")]
		public long Amount { get; set; }
	}
}
