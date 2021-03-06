using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
	{
		public partial class PdCrewSlot
		{
			[JsonProperty("symbol")]
			public string Symbol { get; set; }

			[JsonProperty("name")]
			public string Name { get; set; }

			[JsonProperty("skill")]
			public PdSkillElement Skill { get; set; }

			[JsonProperty("trait")]
			public string Trait { get; set; }
		}
	}
