using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdPvpTimer
	{
		[JsonProperty("supports_rewarding")]
		public bool SupportsRewarding { get; set; }

		[JsonProperty("pvp_allowed")]
		public bool PvpAllowed { get; set; }

		[JsonProperty("changes_in")]
		public double ChangesIn { get; set; }
	}
}
