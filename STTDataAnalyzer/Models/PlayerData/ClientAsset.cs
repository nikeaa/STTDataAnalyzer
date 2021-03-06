using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class ClientAsset
	{
		[JsonProperty("system")]
		public string System { get; set; }

		[JsonProperty("place")]
		public string Place { get; set; }
	}
}
