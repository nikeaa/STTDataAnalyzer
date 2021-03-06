using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdBuff
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("short_name")]
		public string ShortName { get; set; }

		[JsonProperty("flavor")]
		public string Flavor { get; set; }

		[JsonProperty("icon")]
		public PdIconClass Icon { get; set; }

		[JsonProperty("operator")]
		public PdOperator Operator { get; set; }

		[JsonProperty("value")]
		public double Value { get; set; }

		[JsonProperty("stat")]
		public string Stat { get; set; }

		[JsonProperty("source")]
		public PdSource Source { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }
	}
}
