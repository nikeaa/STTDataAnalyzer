using System.Collections.Generic;

namespace STTDataAnalyzer.Models
{
	public class DataCoreEquipment
	{
		public string Name;
		public int Level;
		public int CraftCost;
		public List<(string, int)> ItemsNeeded;
	}
}
