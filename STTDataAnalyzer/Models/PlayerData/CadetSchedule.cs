using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdCadetSchedule
	{
		[JsonProperty("day")]
		public long Day { get; set; }

		[JsonProperty("schedule")]
		public List<PdSchedule> Schedule { get; set; }

		[JsonProperty("missions")]
		public List<PdMission> Missions { get; set; }

		[JsonProperty("current")]
		public long Current { get; set; }

		[JsonProperty("ends_in")]
		public double EndsIn { get; set; }

		[JsonProperty("next")]
		public long Next { get; set; }

		[JsonProperty("next_starts_in")]
		public double NextStartsIn { get; set; }
	}
}
