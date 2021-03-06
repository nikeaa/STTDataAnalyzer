using Newtonsoft.Json;
using System;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class CommunityLink
	{
		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("image")]
		public PdCommunityLinkImage Image { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("date")]
		public string Date { get; set; }

		[JsonProperty("url")]
		public Uri Url { get; set; }
	}
}
