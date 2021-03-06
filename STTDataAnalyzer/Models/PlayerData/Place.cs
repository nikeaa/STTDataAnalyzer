using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class Place
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("system")]
		public string System { get; set; }

		[JsonProperty("client_asset")]
		public ClientAsset ClientAsset { get; set; }

		[JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
		public string DisplayName { get; set; }

		[JsonProperty("visited", NullValueHandling = NullValueHandling.Ignore)]
		public bool? Visited { get; set; }
	}
}
