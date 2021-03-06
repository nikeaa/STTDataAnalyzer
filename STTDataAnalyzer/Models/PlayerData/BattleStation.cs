using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdBattleStation
	{
		[JsonProperty("skill")]
		public PdSkillElement Skill { get; set; }
	}
}
