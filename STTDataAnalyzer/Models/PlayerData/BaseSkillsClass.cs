namespace STTDataAnalyzer.Models.PlayerData
	{
		using Newtonsoft.Json;

		public partial class PdBaseSkillsClass
		{
			[JsonProperty("security_skill", NullValueHandling = NullValueHandling.Ignore)]
			public PdSkill SecuritySkill { get; set; }

			[JsonProperty("medicine_skill", NullValueHandling = NullValueHandling.Ignore)]
			public PdSkill MedicineSkill { get; set; }

			[JsonProperty("engineering_skill", NullValueHandling = NullValueHandling.Ignore)]
			public PdSkill EngineeringSkill { get; set; }

			[JsonProperty("command_skill", NullValueHandling = NullValueHandling.Ignore)]
			public PdSkill CommandSkill { get; set; }

			[JsonProperty("diplomacy_skill", NullValueHandling = NullValueHandling.Ignore)]
			public PdSkill DiplomacySkill { get; set; }

			[JsonProperty("science_skill", NullValueHandling = NullValueHandling.Ignore)]
			public PdSkill ScienceSkill { get; set; }
		}
	}
