using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdMailbox
	{
		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("sendable")]
		public long Sendable { get; set; }

		[JsonProperty("sent")]
		public long Sent { get; set; }

		[JsonProperty("accepted")]
		public long Accepted { get; set; }

		[JsonProperty("stores")]
		public Dictionary<string, long> Stores { get; set; }

		[JsonProperty("received")]
		public long Received { get; set; }
	}
}
