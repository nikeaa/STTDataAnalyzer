using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdFleetInvite
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
		public PdStores Stores { get; set; }

		[JsonProperty("received")]
		public long Received { get; set; }
	}
}
