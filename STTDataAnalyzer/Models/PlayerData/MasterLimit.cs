using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdMasterLimit
	{
		[JsonProperty("chance")]
		public long Chance { get; set; }

		[JsonProperty("period_minutes")]
		public long PeriodMinutes { get; set; }
	}
}
