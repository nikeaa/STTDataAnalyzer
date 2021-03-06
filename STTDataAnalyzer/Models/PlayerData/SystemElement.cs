using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class SystemElement
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("x")]
		public long X { get; set; }

		[JsonProperty("y")]
		public long Y { get; set; }

		[JsonProperty("default_place")]
		public string DefaultPlace { get; set; }

		[JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
		public string DisplayName { get; set; }

		[JsonProperty("star", NullValueHandling = NullValueHandling.Ignore)]
		public long? Star { get; set; }

		[JsonProperty("decorator", NullValueHandling = NullValueHandling.Ignore)]
		public long? Decorator { get; set; }

		[JsonProperty("faction", NullValueHandling = NullValueHandling.Ignore)]
		public string Faction { get; set; }

		[JsonProperty("scale", NullValueHandling = NullValueHandling.Ignore)]
		public long? Scale { get; set; }

		[JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
		public bool? Active { get; set; }
	}
}
