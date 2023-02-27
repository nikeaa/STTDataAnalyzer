using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class PerFaction
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("count")]
		public int Count { get; set; }

		[JsonProperty("exclusive")]
		public int Exclusive { get; set; }
	}
}