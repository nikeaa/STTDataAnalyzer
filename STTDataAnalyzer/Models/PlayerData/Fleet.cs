using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdFleet
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("nicon_index")]
		public long NiconIndex { get; set; }

		[JsonProperty("nleader_player_dbid")]
		public long NleaderPlayerDbid { get; set; }

		[JsonProperty("nstarbase_level")]
		public long NstarbaseLevel { get; set; }

		[JsonProperty("nleader_login")]
		public long NleaderLogin { get; set; }

		[JsonProperty("slabel")]
		public string Slabel { get; set; }

		[JsonProperty("cursize")]
		public long Cursize { get; set; }

		[JsonProperty("maxsize")]
		public long Maxsize { get; set; }

		[JsonProperty("created")]
		public long Created { get; set; }

		[JsonProperty("enrollment")]
		public string Enrollment { get; set; }

		[JsonProperty("nmin_level")]
		public long NminLevel { get; set; }

		[JsonProperty("rank")]
		public string Rank { get; set; }

		[JsonProperty("epoch_time")]
		public long EpochTime { get; set; }
	}
}
