using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class ItemSource
	{
		[JsonProperty("type")]
		public int Type { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("energy_quotient")]
		public double EnergyQuotient { get; set; }

		[JsonProperty("chance_grade")]
		public int ChanceGrade { get; set; }

		[JsonProperty("dispute")]
		public int Dispute { get; set; }

		[JsonProperty("mastery")]
		public int Mastery { get; set; }

		[JsonProperty("mission_symbol")]
		public string MissionSymbol { get; set; }

		[JsonProperty("cost")]
		public int Cost { get; set; }

		[JsonProperty("avg_cost")]
		public double AverageCost { get; set; }
	}
}