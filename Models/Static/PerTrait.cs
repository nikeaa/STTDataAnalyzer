using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class PerTrait
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("count")]
		public int Count { get; set; }
	}
}