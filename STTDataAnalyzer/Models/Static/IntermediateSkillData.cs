using System;
using System.Collections.Generic;
using STTDataAnalyzer.Converters;
using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class IntermediateSkillData
	{
		[JsonProperty("rarity")]
		public int Rarity { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }

		[JsonProperty("base_skills")]
		[JsonConverter(typeof(BaseSkillsConverter))]
		public List<Skill> BaseSkills { get; set; }

		[JsonProperty("action")]
		public Action Action { get; set; }

		[JsonProperty("ship_battle")]
		public ShipBattle ShipBattle { get; set; }
	}
}
