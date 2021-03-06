using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdSummary
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("min")]
		public long Min { get; set; }

		[JsonProperty("max")]
		public long Max { get; set; }
	}
}
