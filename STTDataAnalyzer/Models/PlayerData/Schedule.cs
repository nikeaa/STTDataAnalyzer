using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdSchedule
	{
		[JsonProperty("day")]
		public long Day { get; set; }

		[JsonProperty("mission")]
		public long Mission { get; set; }
	}
}
