using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdFleetActivity
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("icon")]
		public PdIcon Icon { get; set; }

		[JsonProperty("area")]
		public string Area { get; set; }

		[JsonProperty("category")]
		public string Category { get; set; }

		[JsonProperty("total_points")]
		public long TotalPoints { get; set; }

		[JsonProperty("current_points")]
		public long CurrentPoints { get; set; }

		[JsonProperty("milestones")]
		public List<PdMilestoneElement> Milestones { get; set; }

		[JsonProperty("claims_available_count")]
		public long ClaimsAvailableCount { get; set; }
	}
}
