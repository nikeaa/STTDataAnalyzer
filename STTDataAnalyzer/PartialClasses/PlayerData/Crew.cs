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
				return (int)(Skills.CommandSkill != null ? (Skills.CommandSkill.Core + ((Skills.CommandSkill.RangeMin + Skills.CommandSkill.RangeMax) / 2)) : 0);
			}
		}
		public int DiplomacyVoyageScore
		{
			get
			{
				return (int)(Skills.DiplomacySkill != null ? (Skills.DiplomacySkill.Core + ((Skills.DiplomacySkill.RangeMin + Skills.DiplomacySkill.RangeMax) / 2)) : 0);
			}
		}
		public int EngineeringVoyageScore
		{
			get
			{
				return (int)(Skills.EngineeringSkill != null ? (Skills.EngineeringSkill.Core + ((Skills.EngineeringSkill.RangeMin + Skills.EngineeringSkill.RangeMax) / 2)) : 0);
			}
		}
		public int MedicineVoyageScore
		{
			get
			{
				return (int)(Skills.MedicineSkill != null ? (Skills.MedicineSkill.Core + ((Skills.MedicineSkill.RangeMin + Skills.MedicineSkill.RangeMax) / 2)) : 0);
			}
		}
		public int ScienceVoyageScore
		{
			get
			{
				return (int)(Skills.ScienceSkill != null ? (Skills.ScienceSkill.Core + ((Skills.ScienceSkill.RangeMin + Skills.ScienceSkill.RangeMax) / 2)) : 0);
			}
		}
		public int SecurityVoyageScore
		{
			get
			{
				return (int)(Skills.SecuritySkill != null ? (Skills.SecuritySkill.Core + ((Skills.SecuritySkill.RangeMin + Skills.SecuritySkill.RangeMax) / 2)) : 0);
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

		public int WeightedVoyageScoreForSkillPair(string primarySkill, string secondarySkill, bool useWeightedScores = false)
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

		public bool HasPrimarySkillForVoyage(VoyageDescription voyageDescription)
		{
			bool result = false;

			switch (voyageDescription.Skills.PrimarySkill)
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

		public int PrimarySkillForVoyageValue(VoyageDescription voyageDescription)
		{
			int result = 0;

			switch (voyageDescription.Skills.PrimarySkill)
			{
				case PdSkillElement.CommandSkill:
					result = CommandVoyageScore;
					break;
				case PdSkillElement.DiplomacySkill:
					result = DiplomacyVoyageScore;
					break;
				case PdSkillElement.EngineeringSkill:
					result = EngineeringVoyageScore;
					break;
				case PdSkillElement.MedicineSkill:
					result = MedicineVoyageScore;
					break;
				case PdSkillElement.ScienceSkill:
					result = ScienceVoyageScore;
					break;
				case PdSkillElement.SecuritySkill:
					result = SecurityVoyageScore;
					break;
			}

			return result;
		}

		public bool HasSecondarySkillForVoyage(VoyageDescription voyageDescription)
		{
			bool result = false;

			switch (voyageDescription.Skills.SecondarySkill)
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

		public int SecondarySkillForVoyageValue(VoyageDescription voyageDescription)
		{
			int result = 0;

			switch (voyageDescription.Skills.SecondarySkill)
			{
				case PdSkillElement.CommandSkill:
					result = CommandVoyageScore;
					break;
				case PdSkillElement.DiplomacySkill:
					result = DiplomacyVoyageScore;
					break;
				case PdSkillElement.EngineeringSkill:
					result = EngineeringVoyageScore;
					break;
				case PdSkillElement.MedicineSkill:
					result = MedicineVoyageScore;
					break;
				case PdSkillElement.ScienceSkill:
					result = ScienceVoyageScore;
					break;
				case PdSkillElement.SecuritySkill:
					result = SecurityVoyageScore;
					break;
			}

			return result;
		}

		public int TertiarySkillForVoyageValue(VoyageDescription voyageDescription) {
			int result = 0;

			if (voyageDescription.Skills.PrimarySkill != PdSkillElement.CommandSkill && voyageDescription.Skills.SecondarySkill != PdSkillElement.CommandSkill) result += CommandVoyageScore;
			if (voyageDescription.Skills.PrimarySkill != PdSkillElement.DiplomacySkill && voyageDescription.Skills.SecondarySkill != PdSkillElement.DiplomacySkill) result += DiplomacyVoyageScore;
			if (voyageDescription.Skills.PrimarySkill != PdSkillElement.EngineeringSkill && voyageDescription.Skills.SecondarySkill != PdSkillElement.EngineeringSkill) result += EngineeringVoyageScore;
			if (voyageDescription.Skills.PrimarySkill != PdSkillElement.MedicineSkill && voyageDescription.Skills.SecondarySkill != PdSkillElement.MedicineSkill) result += MedicineVoyageScore;
			if (voyageDescription.Skills.PrimarySkill != PdSkillElement.ScienceSkill && voyageDescription.Skills.SecondarySkill != PdSkillElement.ScienceSkill) result += ScienceVoyageScore;
			if (voyageDescription.Skills.PrimarySkill != PdSkillElement.SecuritySkill && voyageDescription.Skills.SecondarySkill != PdSkillElement.SecuritySkill) result += SecurityVoyageScore;

			return result;
		}
	}
}
