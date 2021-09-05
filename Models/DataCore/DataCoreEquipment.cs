using System.Collections.Generic;
using System.IO;

namespace STTDataAnalyzer.Models.DataCore
{
	public class DataCoreEquipment
	{
		public string Name;
		public int Level;
		public int CraftCost;
		public List<(string, int)> ItemsNeeded;
	}
}
