using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class Dispute
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("episode")]
		public int Episode { get; set; }

		[JsonProperty("marker")]
		public int[] Markers { get; set; }

		[JsonProperty("mission_ids")]
		public int[] MissionIds { get; set; }

		[JsonProperty("total_stars")]
		public int TotalStars { get; set; }

		[JsonProperty("exclude_from_timeline")]
		public bool ExcludeFromTimeline { get; set; }

		[JsonProperty("faction_id")]
		public int FactionId { get; set; }
	}
}