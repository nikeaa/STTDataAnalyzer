using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class Quest
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("quest_type")]
		public string QuestType { get; set; }

		[JsonProperty("status")]
		public int Status { get; set; }

		[JsonProperty("current_quest_path")]
		public string CurrentQuestPath { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("action")]
		public string Action { get; set; }

		[JsonProperty("place")]
		public string Place { get; set; }

		[JsonProperty("notifier_icon")]
		public Icon	NotifierIcon{ get; set; }

		[JsonProperty("intro")]
		public Intro Intro{ get; set; }

		[JsonProperty("traits_used")]
		public string[] TraitsUsed { get; set; }

		[JsonProperty("crew")]
		public string[] Crew { get; set; }

		[JsonProperty("stages")]
		public Stage[] Stages { get; set; }

		[JsonProperty("starting_challenge_id")]
		public int StartingChallengeId { get; set; }

		[JsonProperty("Challenge")]
		public Challenge[] Challenges { get; set; }

		[JsonProperty("locked")]
		public bool Locked { get; set; }

		[JsonProperty("star_background")]
		public bool StarBackground { get; set; }

		[JsonProperty("material_bundle")]
		public string MaterialBundle { get; set; }

		[JsonProperty("mastery_levels")]
		public MasteryLevel[] MasteryLevels { get; set; }

		[JsonProperty("warpLogs")]
		public WarpLog[] WarpLogs { get; set; }

		[JsonProperty("timeline_icon")]
		public Icon TimelineIcon { get; set; }

		[JsonProperty("mission_id")]
		public int MissionId { get; set; }

		[JsonProperty("mission")]
		public Mission Mission { get; set; }
	}
}