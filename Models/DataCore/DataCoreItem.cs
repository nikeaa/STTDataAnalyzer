using System.Collections.Generic;

namespace STTDataAnalyzer.Models.DataCore
{
	public class DataCoreItem
	{
		public string Name;
		public int Rarity;
		public int Quantity;
		public int Type;
		public string Flavor;
		public string Symbol;
		public Dictionary<string, int> Bonuses;
		public string Image;
	}
}
