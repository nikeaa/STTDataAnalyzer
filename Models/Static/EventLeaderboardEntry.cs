using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class EventLeaderboardEntry
	{
		[JsonProperty("dbid")]
		public long DBId { get; set; }

		[JsonProperty("display_name")]
		public string DisplayName { get; set; }

		[JsonProperty("pid")]
		public int PId { get; set; }

		[JsonProperty("avatar")]
		public Icon Avatar { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }

		[JsonProperty("uid")]
		public int UId { get; set; }

		[JsonProperty("rank")]
		public int Rank { get; set; }

		[JsonProperty("score")]
		public int Score { get; set; }

		[JsonProperty("fleetid")]
		public long FleetId { get; set; }
	}
}