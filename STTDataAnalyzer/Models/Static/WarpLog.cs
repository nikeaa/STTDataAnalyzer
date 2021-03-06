using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class WarpLog
	{

		[JsonProperty("quest_id")]
		public int QuestId { get; set; }

		[JsonProperty("quest_name")]
		public string QuestName { get; set; }

		[JsonProperty("mastery_level")]
		public int MasteryLevel { get; set; }

		[JsonProperty("warp_count")]
		public int WarpCount { get; set; }

		[JsonProperty("averages")]
		public Average[] Averages { get; set; }

		[JsonProperty("rewards")]
		public PotentialReward[] Rewards { get; set; }
	}
}