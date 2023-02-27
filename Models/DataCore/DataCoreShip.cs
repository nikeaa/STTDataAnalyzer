using System.Collections.Generic;

namespace STTDataAnalyzer.Models.DataCore
{
	public class DataCoreShip
	{
		public string Name;
		public bool Owned;
		public int Rarity;
		public int Level;
		public int MaxLevel;
		public int Antimatter;
		public int Accuracy;
		public int Attack;
		public decimal AttacksPerSecond;
		public int CritBonus;
		public int CritChance;
		public int Evasion;
		public int Hull;
		public int Shields;
		public int ShieldRegen;
		public List<string> Traits;
	}
}
