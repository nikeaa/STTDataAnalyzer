using System.Collections.Generic;

namespace STTDataAnalyzer.Models.DataCore
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
				return 0;
			}
		}
	}
}
