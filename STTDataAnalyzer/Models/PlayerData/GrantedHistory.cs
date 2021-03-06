using Newtonsoft.Json;
using System;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdGrantedHistory
	{
		[JsonProperty("what")]
		public PdFromEnum What { get; set; }

		[JsonProperty("when")]
		public DateTimeOffset When { get; set; }

		[JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
		public PdFromEnum? To { get; set; }

		[JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
		public PdFromEnum? From { get; set; }

		[JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
		public PdReason? Reason { get; set; }
	}
}
