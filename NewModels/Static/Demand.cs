using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class Demand
	{
		[JsonProperty("count")]
		public int Count { get; set; }

		[JsonProperty("factionOnly")]
		public bool FactionOnly { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }
	}
}