using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class CrossFuseTarget
	{
		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}
}