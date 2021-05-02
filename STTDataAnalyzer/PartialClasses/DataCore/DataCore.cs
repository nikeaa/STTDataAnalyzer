using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace STTDataAnalyzer.Models.DataCore
{
	public partial class DataCore
	{
		public IOrderedEnumerable<DataCoreCrew> LegendaryCrewOrderedByTier() {
			return Crew.Where(c => c.MaxRarity == 5 && c.Have == true && c.Rarity != c.MaxRarity && c.Level != 100).OrderBy(c => c.Tier);
		}
	}
}
