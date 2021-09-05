using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class Filter
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("trait")]
		public string Trait { get; set; }

		[JsonProperty("skill")]
		public string Skill { get; set; }

		[JsonProperty("rarity")]
		public int Rarity { get; set; }
	}
}