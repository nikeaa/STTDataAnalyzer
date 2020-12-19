using System.Collections.Generic;

namespace STTDataAnalyzer.Models
{
	public class DataCoreCrew
	{
		public string Name;
		public bool Have;
		public string ShortName;
		public int MaxRarity;
		public int Rarity;
		public int Level;
		public int Immortal;
		public string Equipment; // should this be some type of list of equipment?
		public int Tier;
		public bool InPortal;
		public List<string> Collections;
		public int VoyageRank;
		public int GauntletRank;
		public Dictionary<string, (int Base, int Min, int Max)> Skills;
		public List<string> Traits;
		public DataCoreCrewAction Action;
		public DataCoreCrewBonus Bonus;
		public int Accuracy;
		public int CritBonus;
		public int CritRating;
		public int Evasion;
		public string ChargePhases;

		public int VoyageCommand {
			get {
				return Skills["CommandSkill"].Base + ((Skills["CommandSkill"].Min + Skills["CommandSkill"].Max) / 2);
			}
		}

		public int VoyageDiplomacy
		{
			get
			{
				return Skills["DiplomacySkill"].Base + ((Skills["DiplomacySkill"].Min + Skills["DiplomacySkill"].Max) / 2);
			}
		}

		public int VoyageEngineering
		{
			get
			{
				return Skills["EngineeringSkill"].Base + ((Skills["EngineeringSkill"].Min + Skills["EngineeringSkill"].Max) / 2);
			}
		}

		public int VoyageMedicine
		{
			get
			{
				return Skills["MedicineSkill"].Base + ((Skills["MedicineSkill"].Min + Skills["MedicineSkill"].Max) / 2);
			}
		}

		public int VoyageScience
		{
			get
			{
				return Skills["ScienceSkill"].Base + ((Skills["ScienceSkill"].Min + Skills["ScienceSkill"].Max) / 2);
			}
		}

		public int VoyageSecurity
		{
			get
			{
				return Skills["SecuritySkill"].Base + ((Skills["SecuritySkill"].Min + Skills["SecuritySkill"].Max) / 2);
			}
		}

		public int VoyageCommandDiplomacy {
			get {
				return VoyageCommand + VoyageDiplomacy;
			}
		}

		public int VoyageCommandEngineering {
			get {
				return VoyageCommand + VoyageEngineering;
			}
		}

		public int VoyageCommandMedicine {
			get {
				return VoyageCommand + VoyageMedicine;
			}
		}

		public int VoyageCommandScience {
			get {
				return VoyageCommand + VoyageScience;
			}
		}

		public int VoyageCommandSecurity {
			get {
				return VoyageCommand + VoyageSecurity;
			}
		}

		public int VoyageDiplomacyCommand {
			get {
				return VoyageDiplomacy + VoyageCommand;
			}
		}

		public int VoyageDiplomacyEngineering {
			get {
				return VoyageDiplomacy + VoyageEngineering;
			}
		}

		public int VoyageDiplomacyMedicine {
			get {
				return VoyageDiplomacy + VoyageMedicine;
			}
		}

		public int VoyageDiplomacyScience {
			get {
				return VoyageDiplomacy + VoyageScience;
			}
		}

		public int VoyageDiplomacySecurity {
			get {
				return VoyageDiplomacy + VoyageSecurity;
			}
		}

		public int VoyageEngineeringCommand {
			get {
				return VoyageEngineering + VoyageCommand;
			}
		}

		public int VoyageEngineeringDiplomacy {
			get {
				return VoyageEngineering + VoyageDiplomacy;
			}
		}

		public int VoyageEngineeringMedicine {
			get {
				return VoyageEngineering + VoyageScience;
			}
		}

		public int VoyageEngineeringScience
		{
			get
			{
				return VoyageEngineering + VoyageScience;
			}
		}

		public int VoyageEngineeringSecurity {
			get {
				return VoyageEngineering + VoyageSecurity;
			}
		}

		public int VoyageMedicineCommand {
			get {
				return VoyageMedicine + VoyageCommand;
			}
		}

		public int VoyageMedicineDiplomacy {
			get {
				return VoyageMedicine + VoyageDiplomacy;
			}
		}

		public int VoyageMedicineEngineering {
			get {
				return VoyageMedicine + VoyageEngineering;
			}
		}

		public int VoyageMedicineScience
		{
			get
			{
				return VoyageMedicine + VoyageScience;
			}
		}

		public int VoyageMedicineSecurity {
			get {
				return VoyageMedicine + VoyageSecurity;
			}
		}

		public int VoyageScienceCommand {
			get {
				return VoyageScience + VoyageCommand;
			}
		}

		public int VoyageScienceDiplomacy {
			get {
				return VoyageScience + VoyageDiplomacy;
			}
		}

		public int VoyageScienceEngineering {
			get {
				return VoyageScience + VoyageEngineering;
			}
		}

		public int VoyageScienceMedicine {
			get {
				return VoyageScience + VoyageMedicine;
			}
		}

		public int VoyageScienceSecurity {
			get {
				return VoyageScience + VoyageSecurity;
			}
		}

		public int VoyageSecurityCommand
		{
			get
			{
				return VoyageSecurity + VoyageCommand;
			}
		}

		public int VoyageSecurityDiplomacy {
			get {
				return VoyageSecurity + VoyageDiplomacy;
			}
		}

		public int VoyageSecurityEngineering {
			get {
				return VoyageSecurity + VoyageEngineering;
			}
		}

		public int VoyageSecurityMedicine {
			get {
				return VoyageSecurity + VoyageMedicine;
			}
		}

		public int VoyageSecurityScience {
			get {
				return VoyageSecurity + VoyageScience;
			}
		}
	}
}
