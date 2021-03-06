using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class Average
	{

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("average")]
		public double AverageValue { get; set; }

		[JsonProperty("average_cost")]
		public double AverageCost { get; set; }
	}
}