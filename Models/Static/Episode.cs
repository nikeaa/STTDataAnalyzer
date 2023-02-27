using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class Episode
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("episode")]
		public int EpisodeNumber { get; set; }

		[JsonProperty("episode_title")]
		public string EpisodeTitle { get; set; }

		[JsonProperty("episode_portrait")]
		public EpisodePortrait EpisodePortrait { get; set; }
		
		[JsonProperty("marker")]
		public int[] Marker { get; set; }

		[JsonProperty("marker_icon")]
		public Icon MarkerIcon { get; set; }

		[JsonProperty("exclude_from_timeline")]
		public bool? ExcludeFromTimeline { get; set; }

		[JsonProperty("total_stars")]
		public int TotalStars { get; set; }

		[JsonProperty("character_xp_reward")]
		public int CharacterXpReward { get; set; }

		[JsonProperty("loot_rewards")]
		public string[] LootRewards { get; set; }

		[JsonProperty("quests")]
		public Quest[] Quests { get; set; }
	}
}