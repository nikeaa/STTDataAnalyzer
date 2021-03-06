using System.Collections.Generic;
using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class SkillBuffs
	{
		[JsonProperty("command")]
		public SkillBuff Command { get; set; }

		[JsonProperty("diplomacy")]
		public SkillBuff Diplomacy { get; set; }

		[JsonProperty("engineering")]
		public SkillBuff Engineering { get; set; }

		[JsonProperty("medicine")]
		public SkillBuff Medicine { get; set; }

		[JsonProperty("science")]
		public SkillBuff Science { get; set; }

		[JsonProperty("security")]
		public SkillBuff Security { get; set; }
	}
}
