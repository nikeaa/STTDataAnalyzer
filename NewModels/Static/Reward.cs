using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class Reward
	{
		[JsonProperty("type")]
		public int Type { get; set; }

		[JsonProperty("icon")]
		public Icon Icon { get; set; }

		[JsonProperty("rarity")]
		public int Rarity { get; set; }

		[JsonProperty("potential_rewards")]
		public PotentialReward[] PotentialRewards { get; set; }

		[JsonProperty("quantity")]
		public int Quantity { get; set; }
	}
}