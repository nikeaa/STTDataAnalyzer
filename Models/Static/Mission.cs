using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class Mission
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("character_xp_reward")]
		public int CharacterXpAward { get; set; }

		[JsonProperty("loot_rewards")]
		public string[] LootRewards { get; set; }

		[JsonProperty("quests")]
		public Quest[] Quests { get; set; }

		[JsonProperty("episode")]
		public int Episode { get; set; }

		[JsonProperty("episode_title")]
		public string EpisodeTitle { get; set; }
	}
}