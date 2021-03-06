using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdMilestoneElement
	{
		[JsonProperty("goal")]
		public long Goal { get; set; }

		[JsonProperty("rewards")]
		public List<PdMilestoneReward> Rewards { get; set; }

		[JsonProperty("claimed")]
		public bool Claimed { get; set; }

		[JsonProperty("claimable")]
		public bool Claimable { get; set; }
	}
}
