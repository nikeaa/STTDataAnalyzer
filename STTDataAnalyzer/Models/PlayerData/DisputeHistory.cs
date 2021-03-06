using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdDisputeHistory
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("episode")]
		public long Episode { get; set; }

		[JsonProperty("marker")]
		public List<long> Marker { get; set; }

		[JsonProperty("completed")]
		public bool Completed { get; set; }

		[JsonProperty("mission_ids")]
		public List<long> MissionIds { get; set; }

		[JsonProperty("stars_earned")]
		public long StarsEarned { get; set; }

		[JsonProperty("total_stars")]
		public long TotalStars { get; set; }

		[JsonProperty("exclude_from_timeline")]
		public bool ExcludeFromTimeline { get; set; }

		[JsonProperty("faction_id")]
		public long FactionId { get; set; }
	}
}
