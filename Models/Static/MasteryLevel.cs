using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class MasteryLevel
	{

		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("energy_cost")]
		public int EnergyCost { get; set; }

		[JsonProperty("rewards")]
		public Reward[] Rewards { get; set; }

		[JsonProperty("locked")]
		public bool Locked { get; set; }

		[JsonProperty("progress")]
		public Progress Progress { get; set; }

		[JsonProperty("jackpots")]
		public Jackpot[] Jackpots { get; set; }

		[JsonProperty("opponent")]
		public Opponent Opponent { get; set; }
	}
}