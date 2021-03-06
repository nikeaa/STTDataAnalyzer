using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdCryoCollectionMilestone
	{
		[JsonProperty("rewards")]
		public List<PdMilestoneReward> Rewards { get; set; }

		[JsonProperty("goal")]
		public long Goal { get; set; }

		[JsonProperty("buffs")]
		public List<ShuttleTokenPreviewItem> Buffs { get; set; }
	}
}
