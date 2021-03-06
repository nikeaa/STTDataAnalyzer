using Newtonsoft.Json;
using STTDataAnalyzer.Converters;
using System;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class ClaimedHistory
	{
		[JsonProperty("what")]
		public PdFromEnum What { get; set; }

		[JsonProperty("when")]
		public DateTimeOffset When { get; set; }

		[JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
		public PdFromEnum? To { get; set; }

		[JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
		public PdFromEnum? From { get; set; }

		[JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ParseStringConverter))]
		public long? Quantity { get; set; }

		[JsonProperty("who", NullValueHandling = NullValueHandling.Ignore)]
		public string Who { get; set; }

		[JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
		public string Image { get; set; }

		[JsonProperty("ecount", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ParseStringConverter))]
		public long? Ecount { get; set; }

		[JsonProperty("reward_image", NullValueHandling = NullValueHandling.Ignore)]
		public string RewardImage { get; set; }

		[JsonProperty("obtain", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(ParseStringConverter))]
		public long? Obtain { get; set; }
	}
}
