using Newtonsoft.Json;
using STTDataAnalyzer.Converters;
using System;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdCommunityLinkImage
	{
		[JsonProperty("file")]
		public Uri File { get; set; }

		[JsonProperty("url")]
		public Uri Url { get; set; }

		[JsonProperty("version")]
		[JsonConverter(typeof(ParseStringConverter))]
		public long Version { get; set; }
	}
}
