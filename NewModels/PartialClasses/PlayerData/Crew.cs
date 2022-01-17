namespace STTDataAnalyzer.Models.PlayerData
{
    public partial class Crew
    {
        public bool HasSkill(string slotSkillName)
        {
            switch (slotSkillName)
            {
                case "Command": return BaseSkills.CommandSkill != null && BaseSkills.CommandSkill.Core > 0;
                case "Diplomacy": return BaseSkills.DiplomacySkill != null && BaseSkills.DiplomacySkill.Core > 0;
                case "Engineering": return BaseSkills.EngineeringSkill != null && BaseSkills.EngineeringSkill.Core > 0;
                case "Medicine": return BaseSkills.MedicineSkill != null && BaseSkills.MedicineSkill.Core > 0;
                case "Science": return BaseSkills.ScienceSkill != null && BaseSkills.ScienceSkill.Core > 0;
                case "Security": return BaseSkills.SecuritySkill != null && BaseSkills.SecuritySkill.Core > 0;
                default: return false;
            }
        }

        public int CommandVoyageScore => Skills.CommandSkill != null ? (int)(Skills.CommandSkill.Core + ((Skills.CommandSkill.RangeMin + Skills.CommandSkill.RangeMax) / 2)) : 0;

        public int DiplomacyVoyageScore => Skills.DiplomacySkill != null ? (int)(Skills.DiplomacySkill.Core + ((Skills.DiplomacySkill.RangeMin + Skills.DiplomacySkill.RangeMax) / 2)): 0;

        public int EngineeringVoyageScore => Skills.EngineeringSkill != null ? (int)(Skills.EngineeringSkill.Core + ((Skills.EngineeringSkill.RangeMin + Skills.EngineeringSkill.RangeMax) / 2)) : 0;

        public int MedicineVoyageScore => Skills.MedicineSkill != null  ? (int)(Skills.MedicineSkill.Core + ((Skills.MedicineSkill.RangeMin + Skills.MedicineSkill.RangeMax) / 2)) : 0;

        public int ScienceVoyageScore => Skills.ScienceSkill != null ? (int)(Skills.ScienceSkill.Core + ((Skills.ScienceSkill.RangeMin + Skills.ScienceSkill.RangeMax) / 2)) : 0;

        public int SecurityVoyageScore => Skills.SecuritySkill != null ? (int)(Skills.SecuritySkill.Core + ((Skills.SecuritySkill.RangeMin + Skills.SecuritySkill.RangeMax) / 2)) : 0;

        public int WeightedVoyageScore(string primarySkillName, string secondarySkillName, string slotTraitName)
        {
            int score = 0;

            int traitBonus = 0;
            if (Traits.Contains(slotTraitName) || TraitsHidden.Contains(slotTraitName)) traitBonus += 200;

            if (primarySkillName == "Command") score += (int)((CommandVoyageScore + traitBonus) * .35);
            else if (secondarySkillName == "Command") score += (int)((CommandVoyageScore + traitBonus) * .25);
            else score += (int)((CommandVoyageScore + traitBonus) * .1);

            if (primarySkillName == "Diplomacy") score += (int)((DiplomacyVoyageScore + traitBonus) * .35);
            else if (secondarySkillName == "Diplomacy") score += (int)((DiplomacyVoyageScore + traitBonus) * .25);
            else score += (int)((DiplomacyVoyageScore + traitBonus) * .1);

            if (primarySkillName == "Engineering") score += (int)((EngineeringVoyageScore + traitBonus) * .35);
            else if (secondarySkillName == "Engineering") score += (int)((EngineeringVoyageScore + traitBonus) * .25);
            else score += (int)((EngineeringVoyageScore + traitBonus) * .1);

            if (primarySkillName == "Medicine") score += (int)((MedicineVoyageScore + traitBonus) * .35);
            else if (secondarySkillName == "Medicine") score += (int)((MedicineVoyageScore + traitBonus) * .25);
            else score += (int)((MedicineVoyageScore + traitBonus) * .1);

            if (primarySkillName == "Science") score += (int)((ScienceVoyageScore + traitBonus) * .35);
            else if (secondarySkillName == "Science") score += (int)((ScienceVoyageScore + traitBonus) * .25);
            else score += (int)((ScienceVoyageScore + traitBonus) * .1);

            if (primarySkillName == "Security") score += (int)((SecurityVoyageScore + traitBonus) * .35);
            else if (secondarySkillName == "Security") score += (int)((SecurityVoyageScore + traitBonus) * .25);
            else score += (int)((SecurityVoyageScore + traitBonus) * .1);

            return score;
        }
    }

    //public partial class PdCrew
    //{
    //	public enum SkillsBitmapEnum {
    //		MedicineSkill = 1,
    //		ScienceSkill = 2,
    //		EngineeringSkill = 4,
    //		SceuritySkill = 8,
    //		DiplomacySkill = 16,
    //		CommandSkill = 32
    //	}
    //public int HasCommandSkill {
    //	get {
    //		if (Skills.CommandSkill != null && Skills.CommandSkill.Core > 0) return 1;
    //		return 0;
    //	}
    //}
    //public int HasDiplomacySkill
    //{
    //	get
    //	{
    //		if (Skills.DiplomacySkill != null && Skills.DiplomacySkill.Core > 0) return 1;
    //		return 0;
    //	}
    //}
    //public int HasEngineeringSkill
    //{
    //	get
    //	{
    //		if (Skills.EngineeringSkill != null && Skills.EngineeringSkill.Core > 0) return 1;
    //		return 0;
    //	}
    //}
    //public int HasMedicineSkill
    //{
    //	get
    //	{
    //		if (Skills.MedicineSkill != null && Skills.MedicineSkill.Core > 0) return 1;
    //		return 0;
    //	}
    //}
    //public int HasScienceSkill
    //{
    //	get
    //	{
    //		if (Skills.ScienceSkill != null && Skills.ScienceSkill.Core > 0) return 1;
    //		return 0;
    //	}
    //}
    //public int HasSecuritySkill
    //{
    //	get
    //	{
    //		if (Skills.SecuritySkill != null && Skills.SecuritySkill.Core > 0) return 1;
    //		return 0;
    //	}
    //}

    //	public int VoyageSkillBitmap {
    //		get {
    //			return HasCommandSkill * 32 + HasDiplomacySkill * 16 + HasSecuritySkill * 8 + HasEngineeringSkill * 4 + HasScienceSkill * 2 + HasMedicineSkill;
    //		}
    //	}
    //	public int CommandVoyageScore
    //	{
    //		get
    //		{
    //			return (int)(Skills.CommandSkill != null ? (Skills.CommandSkill.Core + ((Skills.CommandSkill.RangeMin + Skills.CommandSkill.RangeMax) / 2)) : 0);
    //		}
    //	}
    //	public int DiplomacyVoyageScore
    //	{
    //		get
    //		{
    //			return (int)(Skills.DiplomacySkill != null ? (Skills.DiplomacySkill.Core + ((Skills.DiplomacySkill.RangeMin + Skills.DiplomacySkill.RangeMax) / 2)) : 0);
    //		}
    //	}
    //	public int EngineeringVoyageScore
    //	{
    //		get
    //		{
    //			return (int)(Skills.EngineeringSkill != null ? (Skills.EngineeringSkill.Core + ((Skills.EngineeringSkill.RangeMin + Skills.EngineeringSkill.RangeMax) / 2)) : 0);
    //		}
    //	}
    //	public int MedicineVoyageScore
    //	{
    //		get
    //		{
    //			return (int)(Skills.MedicineSkill != null ? (Skills.MedicineSkill.Core + ((Skills.MedicineSkill.RangeMin + Skills.MedicineSkill.RangeMax) / 2)) : 0);
    //		}
    //	}
    //	public int ScienceVoyageScore
    //	{
    //		get
    //		{
    //			return (int)(Skills.ScienceSkill != null ? (Skills.ScienceSkill.Core + ((Skills.ScienceSkill.RangeMin + Skills.ScienceSkill.RangeMax) / 2)) : 0);
    //		}
    //	}
    //	public int SecurityVoyageScore
    //	{
    //		get
    //		{
    //			return (int)(Skills.SecuritySkill != null ? (Skills.SecuritySkill.Core + ((Skills.SecuritySkill.RangeMin + Skills.SecuritySkill.RangeMax) / 2)) : 0);
    //		}
    //	}

    //	private Dictionary<string, int> _voyageScores = null;
    //	public Dictionary<string, int> VoyageScores
    //	{
    //		get
    //		{
    //			if (_voyageScores == null)
    //			{
    //				_voyageScores = new Dictionary<string, int>();

    //				_voyageScores.Add("CommandSkill", CommandVoyageScore);
    //				_voyageScores.Add("DiplomacySkill", DiplomacyVoyageScore);
    //				_voyageScores.Add("EngineeringSkill", EngineeringVoyageScore);
    //				_voyageScores.Add("MedicineSkill", MedicineVoyageScore);
    //				_voyageScores.Add("ScienceSkill", ScienceVoyageScore);
    //				_voyageScores.Add("SecuritySkill", SecurityVoyageScore);
    //			}

    //			return _voyageScores;
    //		}
    //	}

    //	public int WeightedVoyageScoreForSkillPair(string primarySkill, string secondarySkill, bool useWeightedScores = false)
    //	{
    //		int result = 0;

    //		int primaryWeight = useWeightedScores ? 35 : 1;
    //		int secondaryWeight = useWeightedScores ? 25 : 1;

    //		result += VoyageScores[primarySkill] * primaryWeight;
    //		result += VoyageScores[secondarySkill] * secondaryWeight;

    //		return result;
    //	}

    //	public bool HasSkillForVoyageSlot(PdCrewSlot voyageCrewSlot)
    //	{
    //		bool result = false;

    //		switch (voyageCrewSlot.Skill)
    //		{
    //			case PdSkillElement.CommandSkill:
    //				result = Skills.CommandSkill != null && Skills.CommandSkill.Core > 0;
    //				break;
    //			case PdSkillElement.DiplomacySkill:
    //				result = Skills.DiplomacySkill != null && Skills.DiplomacySkill.Core > 0;
    //				break;
    //			case PdSkillElement.EngineeringSkill:
    //				result = Skills.EngineeringSkill != null && Skills.EngineeringSkill.Core > 0;
    //				break;
    //			case PdSkillElement.MedicineSkill:
    //				result = Skills.MedicineSkill != null && Skills.MedicineSkill.Core > 0;
    //				break;
    //			case PdSkillElement.ScienceSkill:
    //				result = Skills.ScienceSkill != null && Skills.ScienceSkill.Core > 0;
    //				break;
    //			case PdSkillElement.SecuritySkill:
    //				result = Skills.SecuritySkill != null && Skills.SecuritySkill.Core > 0;
    //				break;
    //		}

    //		return result;
    //	}

    //	public bool HasPrimarySkillForVoyage(VoyageDescription voyageDescription)
    //	{
    //		bool result = false;

    //		switch (voyageDescription.Skills.PrimarySkill)
    //		{
    //			case PdSkillElement.CommandSkill:
    //				result = Skills.CommandSkill != null && Skills.CommandSkill.Core > 0;
    //				break;
    //			case PdSkillElement.DiplomacySkill:
    //				result = Skills.DiplomacySkill != null && Skills.DiplomacySkill.Core > 0;
    //				break;
    //			case PdSkillElement.EngineeringSkill:
    //				result = Skills.EngineeringSkill != null && Skills.EngineeringSkill.Core > 0;
    //				break;
    //			case PdSkillElement.MedicineSkill:
    //				result = Skills.MedicineSkill != null && Skills.MedicineSkill.Core > 0;
    //				break;
    //			case PdSkillElement.ScienceSkill:
    //				result = Skills.ScienceSkill != null && Skills.ScienceSkill.Core > 0;
    //				break;
    //			case PdSkillElement.SecuritySkill:
    //				result = Skills.SecuritySkill != null && Skills.SecuritySkill.Core > 0;
    //				break;
    //		}

    //		return result;
    //	}

    //	public int PrimarySkillForVoyageValue(VoyageDescription voyageDescription)
    //	{
    //		int result = 0;

    //		switch (voyageDescription.Skills.PrimarySkill)
    //		{
    //			case PdSkillElement.CommandSkill:
    //				result = CommandVoyageScore;
    //				break;
    //			case PdSkillElement.DiplomacySkill:
    //				result = DiplomacyVoyageScore;
    //				break;
    //			case PdSkillElement.EngineeringSkill:
    //				result = EngineeringVoyageScore;
    //				break;
    //			case PdSkillElement.MedicineSkill:
    //				result = MedicineVoyageScore;
    //				break;
    //			case PdSkillElement.ScienceSkill:
    //				result = ScienceVoyageScore;
    //				break;
    //			case PdSkillElement.SecuritySkill:
    //				result = SecurityVoyageScore;
    //				break;
    //		}

    //		return result;
    //	}

    //	public bool HasSecondarySkillForVoyage(VoyageDescription voyageDescription)
    //	{
    //		bool result = false;

    //		switch (voyageDescription.Skills.SecondarySkill)
    //		{
    //			case PdSkillElement.CommandSkill:
    //				result = Skills.CommandSkill != null && Skills.CommandSkill.Core > 0;
    //				break;
    //			case PdSkillElement.DiplomacySkill:
    //				result = Skills.DiplomacySkill != null && Skills.DiplomacySkill.Core > 0;
    //				break;
    //			case PdSkillElement.EngineeringSkill:
    //				result = Skills.EngineeringSkill != null && Skills.EngineeringSkill.Core > 0;
    //				break;
    //			case PdSkillElement.MedicineSkill:
    //				result = Skills.MedicineSkill != null && Skills.MedicineSkill.Core > 0;
    //				break;
    //			case PdSkillElement.ScienceSkill:
    //				result = Skills.ScienceSkill != null && Skills.ScienceSkill.Core > 0;
    //				break;
    //			case PdSkillElement.SecuritySkill:
    //				result = Skills.SecuritySkill != null && Skills.SecuritySkill.Core > 0;
    //				break;
    //		}

    //		return result;
    //	}

    //	public int SecondarySkillForVoyageValue(VoyageDescription voyageDescription)
    //	{
    //		int result = 0;

    //		switch (voyageDescription.Skills.SecondarySkill)
    //		{
    //			case PdSkillElement.CommandSkill:
    //				result = CommandVoyageScore;
    //				break;
    //			case PdSkillElement.DiplomacySkill:
    //				result = DiplomacyVoyageScore;
    //				break;
    //			case PdSkillElement.EngineeringSkill:
    //				result = EngineeringVoyageScore;
    //				break;
    //			case PdSkillElement.MedicineSkill:
    //				result = MedicineVoyageScore;
    //				break;
    //			case PdSkillElement.ScienceSkill:
    //				result = ScienceVoyageScore;
    //				break;
    //			case PdSkillElement.SecuritySkill:
    //				result = SecurityVoyageScore;
    //				break;
    //		}

    //		return result;
    //	}

    //	public int TertiarySkillForVoyageValue(VoyageDescription voyageDescription) {
    //		int result = 0;

    //		if (voyageDescription.Skills.PrimarySkill != PdSkillElement.CommandSkill && voyageDescription.Skills.SecondarySkill != PdSkillElement.CommandSkill) result += CommandVoyageScore;
    //		if (voyageDescription.Skills.PrimarySkill != PdSkillElement.DiplomacySkill && voyageDescription.Skills.SecondarySkill != PdSkillElement.DiplomacySkill) result += DiplomacyVoyageScore;
    //		if (voyageDescription.Skills.PrimarySkill != PdSkillElement.EngineeringSkill && voyageDescription.Skills.SecondarySkill != PdSkillElement.EngineeringSkill) result += EngineeringVoyageScore;
    //		if (voyageDescription.Skills.PrimarySkill != PdSkillElement.MedicineSkill && voyageDescription.Skills.SecondarySkill != PdSkillElement.MedicineSkill) result += MedicineVoyageScore;
    //		if (voyageDescription.Skills.PrimarySkill != PdSkillElement.ScienceSkill && voyageDescription.Skills.SecondarySkill != PdSkillElement.ScienceSkill) result += ScienceVoyageScore;
    //		if (voyageDescription.Skills.PrimarySkill != PdSkillElement.SecuritySkill && voyageDescription.Skills.SecondarySkill != PdSkillElement.SecuritySkill) result += SecurityVoyageScore;

    //		return result;
    //	}
    //}
}
