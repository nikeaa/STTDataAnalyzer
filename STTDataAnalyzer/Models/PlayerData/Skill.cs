using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdSkill
	{
		[JsonProperty("core")]
		public long Core { get; set; }

		[JsonProperty("range_min")]
		public long RangeMin { get; set; }

		[JsonProperty("range_max")]
		public long RangeMax { get; set; }
	}
}
