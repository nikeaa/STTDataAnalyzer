using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class Ability
	{
		[JsonProperty("condition")]
		public int Condition { get; set; }

		[JsonProperty("type")]
		public int Type { get; set; }

		[JsonProperty("amount")]
		public int Amount { get; set; }
	}
}
