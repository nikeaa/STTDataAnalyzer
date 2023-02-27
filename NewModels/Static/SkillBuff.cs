using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class SkillBuff
	{
		[JsonProperty("core")]
		public double Core { get; set; }

		[JsonProperty("range_min")]
		public double RangeMin { get; set; }

		[JsonProperty("range_max")]
		public double RangeMax { get; set; }

	}
}