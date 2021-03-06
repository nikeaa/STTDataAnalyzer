using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdCryoCollection
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("type_id")]
		public long TypeId { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("image")]
		public string Image { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("progress")]
		public long Progress { get; set; }

		[JsonProperty("traits")]
		public List<string> Traits { get; set; }

		[JsonProperty("extra_crew")]
		public List<long> ExtraCrew { get; set; }

		[JsonProperty("claimable_milestone_index")]
		public long ClaimableMilestoneIndex { get; set; }

		[JsonProperty("milestone")]
		public PdCryoCollectionMilestone Milestone { get; set; }
	}
}
