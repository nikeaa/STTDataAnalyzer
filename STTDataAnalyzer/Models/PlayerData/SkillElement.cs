using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace STTDataAnalyzer.Models.PlayerData
{
	public enum PdSkillElement
	{
		[EnumMember(Value = "command_skill")]
		CommandSkill,
		[EnumMember(Value = "diplomacy_skill")]
		DiplomacySkill,
		[EnumMember(Value = "engineering_skill")]
		EngineeringSkill,
		[EnumMember(Value = "medicine_skill")]
		MedicineSkill,
		[EnumMember(Value = "science_skill")]
		ScienceSkill,
		[EnumMember(Value = "security_skill")]
		SecuritySkill
	};
}
