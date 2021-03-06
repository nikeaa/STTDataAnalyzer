using System;
using System.Collections.Generic;
using System.Text;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdCrew
	{
		public int CommandVoyageScore
		{
			get
			{
				return (int)(BaseSkills.CommandSkill != null ? (BaseSkills.CommandSkill.Core + ((BaseSkills.CommandSkill.RangeMin + BaseSkills.CommandSkill.RangeMax) / 2)) : 0);
			}
		}
		public int DiplomacyVoyageScore
		{
			get
			{
				return (int)(BaseSkills.DiplomacySkill != null ? (BaseSkills.DiplomacySkill.Core + ((BaseSkills.DiplomacySkill.RangeMin + BaseSkills.DiplomacySkill.RangeMax) / 2)) : 0);
			}
		}
		public int EngineeringVoyageScore
		{
			get
			{
				return (int)(BaseSkills.EngineeringSkill != null ? (BaseSkills.EngineeringSkill.Core + ((BaseSkills.EngineeringSkill.RangeMin + BaseSkills.EngineeringSkill.RangeMax) / 2)) : 0);
			}
		}
		public int MedicineVoyageScore
		{
			get
			{
				return (int)(BaseSkills.MedicineSkill != null ? (BaseSkills.MedicineSkill.Core + ((BaseSkills.MedicineSkill.RangeMin + BaseSkills.MedicineSkill.RangeMax) / 2)) : 0);
			}
		}
		public int ScienceVoyageScore
		{
			get
			{
				return (int)(BaseSkills.ScienceSkill != null ? (BaseSkills.ScienceSkill.Core + ((BaseSkills.ScienceSkill.RangeMin + BaseSkills.ScienceSkill.RangeMax) / 2)) : 0);
			}
		}
		public int SecurityVoyageScore
		{
			get
			{
				return (int)(BaseSkills.SecuritySkill != null ? (BaseSkills.SecuritySkill.Core + ((BaseSkills.SecuritySkill.RangeMin + BaseSkills.SecuritySkill.RangeMax) / 2)) : 0);
			}
		}

		private Dictionary<string, int> _voyageScores = null;
		public Dictionary<string, int> VoyageScores
		{
			get
			{
				if (_voyageScores == null)
				{
					_voyageScores = new Dictionary<string, int>();

					_voyageScores.Add("CommandSkill", CommandVoyageScore);
					_voyageScores.Add("DiplomacySkill", DiplomacyVoyageScore);
					_voyageScores.Add("EngineeringSkill", EngineeringVoyageScore);
					_voyageScores.Add("MedicineSkill", MedicineVoyageScore);
					_voyageScores.Add("ScienceSkill", ScienceVoyageScore);
					_voyageScores.Add("SecuritySkill", SecurityVoyageScore);
				}

				return _voyageScores;
			}
		}

		public int VoyageScoreForSkillPair(string primarySkill, string secondarySkill, bool useWeightedScores = false)
		{
			int result = 0;

			int primaryWeight = useWeightedScores ? 35 : 1;
			int secondaryWeight = useWeightedScores ? 25 : 1;

			result += VoyageScores[primarySkill] * primaryWeight;
			result += VoyageScores[secondarySkill] * secondaryWeight;

			return result;
		}

		public bool HasSkillForVoyageSlot(PdCrewSlot voyageCrewSlot)
		{
			bool result = false;

			switch (voyageCrewSlot.Skill)
			{
				case PdSkillElement.CommandSkill:
					result = Skills.CommandSkill != null && Skills.CommandSkill.Core > 0;
					break;
				case PdSkillElement.DiplomacySkill:
					result = Skills.DiplomacySkill != null && Skills.DiplomacySkill.Core > 0;
					break;
				case PdSkillElement.EngineeringSkill:
					result = Skills.EngineeringSkill != null && Skills.EngineeringSkill.Core > 0;
					break;
				case PdSkillElement.MedicineSkill:
					result = Skills.MedicineSkill != null && Skills.MedicineSkill.Core > 0;
					break;
				case PdSkillElement.ScienceSkill:
					result = Skills.ScienceSkill != null && Skills.ScienceSkill.Core > 0;
					break;
				case PdSkillElement.SecuritySkill:
					result = Skills.SecuritySkill != null && Skills.SecuritySkill.Core > 0;
					break;
			}

			return result;
		}
	}
}
