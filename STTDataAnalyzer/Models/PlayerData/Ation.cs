using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdAtion
	{
		[JsonProperty("system")]
		public string System { get; set; }

		[JsonProperty("place")]
		public string Place { get; set; }

		[JsonProperty("setup")]
		public string Setup { get; set; }

		[JsonProperty("x")]
		public long X { get; set; }

		[JsonProperty("y")]
		public long Y { get; set; }
	}
}
