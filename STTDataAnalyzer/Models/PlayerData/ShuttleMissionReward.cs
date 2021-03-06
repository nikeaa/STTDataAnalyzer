using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdShuttleMissionReward
	{
		[JsonProperty("type")]
		public long Type { get; set; }

		[JsonProperty("icon")]
		public PdIconClass Icon { get; set; }

		[JsonProperty("rarity", NullValueHandling = NullValueHandling.Ignore)]
		public long? Rarity { get; set; }

		[JsonProperty("potential_rewards", NullValueHandling = NullValueHandling.Ignore)]
		public List<ShuttleTokenPreviewItem> PotentialRewards { get; set; }

		[JsonProperty("quantity")]
		public long Quantity { get; set; }

		[JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
		public long? Id { get; set; }

		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
		public string Name { get; set; }
	}
}
