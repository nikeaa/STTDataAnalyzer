namespace STTDataAnalyzer.Models.PlayerData
{
	using Newtonsoft.Json;
	using System.Collections.Generic;

	public partial class Claimed
	{
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("gamerTag")]
		public long GamerTag { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("state")]
		public PdFromEnum State { get; set; }

		[JsonProperty("updated")]
		public long Updated { get; set; }

		[JsonProperty("history")]
		public List<ClaimedHistory> History { get; set; }

		[JsonProperty("specialized", NullValueHandling = NullValueHandling.Ignore)]
		public string Specialized { get; set; }

		[JsonProperty("cwin", NullValueHandling = NullValueHandling.Ignore)]
		public PdCwin Cwin { get; set; }

		[JsonProperty("cwinSecsTillOpen", NullValueHandling = NullValueHandling.Ignore)]
		public long? CwinSecsTillOpen { get; set; }

		[JsonProperty("cwinSecsTillClose", NullValueHandling = NullValueHandling.Ignore)]
		public long? CwinSecsTillClose { get; set; }

		[JsonProperty("ttl", NullValueHandling = NullValueHandling.Ignore)]
		public long? Ttl { get; set; }
	}
}
