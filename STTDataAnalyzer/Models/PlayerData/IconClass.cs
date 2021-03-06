using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdIconClass
	{
		[JsonProperty("file")]
		public string File { get; set; }
	}
}
