using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class Jackpot
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("reward")]
		public JackpotReward[] Reward { get; set; }

		[JsonProperty("claimed")]
		public bool Claimed { get; set; }
	}
}