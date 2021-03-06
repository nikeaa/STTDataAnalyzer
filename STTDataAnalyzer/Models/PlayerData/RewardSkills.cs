using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdRewardSkills
	{
		[JsonProperty("diplomacy_skill")]
		public PdSkill DiplomacySkill { get; set; }

		[JsonProperty("command_skill", NullValueHandling = NullValueHandling.Ignore)]
		public PdSkill CommandSkill { get; set; }

		[JsonProperty("security_skill", NullValueHandling = NullValueHandling.Ignore)]
		public PdSkill SecuritySkill { get; set; }
	}
}
