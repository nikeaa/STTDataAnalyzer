using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class VoyageDescriptionSkills
	{
		[JsonProperty("primary_skill")]
		public PdSkillElement PrimarySkill { get; set; }

		[JsonProperty("secondary_skill")]
		public PdSkillElement SecondarySkill { get; set; }
	}
}
