using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace STTDataAnalyzer
{
	namespace SttUser
	{
		public partial class ItemArchetypeCache
		{
			public IOrderedEnumerable<Archetype> GetItemsNotInSpaceBattles()
			{
				return Archetypes.Where(i => i.ItemSources != null && i.ItemSources.Count > 0 && i.Recipe == null && !i.ItemSources.Any(ii => ii.Type == 2)).OrderBy(i => i.Name).ThenBy(i => i.Rarity);
			}

			public void WriteArchetypesSpreadsheet(string fileLocation)
			{
				List<string> lines = new List<string>();
				foreach (Archetype archetype in Archetypes)
				{
					// format: id, symbol, type, name, rarity, away, space, faction, one-time
					bool away = archetype.ItemSources.Any(i => i.Type == 0);
					bool space = archetype.ItemSources.Any(i => i.Type == 2);
					bool faction = archetype.ItemSources.Any(i => i.Type == 1);
					bool oneTime = archetype.ItemSources.Any(i => i.Type == 3);

					string line = QuoteIt(archetype.Id.ToString()) + "," + QuoteIt(archetype.Symbol) + "," + QuoteIt(archetype.Type.ToString()) + ",";
					line += QuoteIt(archetype.Name) + "," + QuoteIt(archetype.Rarity.ToString()) + "," + QuoteIt(away.ToString()) + ",";
					line += QuoteIt(space.ToString()) + "," + QuoteIt(faction.ToString()) + "," + QuoteIt(oneTime.ToString());
					lines.Add(line);
				}

				File.WriteAllLines("archetypes.csv", lines);
			}
			public List<(int, int, string)> GetExpandedRecipe(string itemSymbol, int level, int quantity)
			{
				List<(int, int, string)> result = new List<(int, int, string)>();

				Archetype item = Archetypes.Where(a => a.Symbol == itemSymbol).Select(a => a).FirstOrDefault();
				if (item != null)
				{
					//Console.WriteLine(new string(' ', level * 2) + quantity + " - " + item.Name + " " + new string('*', (int)item.Rarity));
					result.Add((level, quantity, item.Name + " " + new string('*', (int)item.Rarity)));
					if (item.Recipe != null)
					{
						for (int i = 0; i < item.Recipe.Demands.Count; i++)
						{
							Archetype subItem = Archetypes.Find(a => a.Id == item.Recipe.Demands[i].ArchetypeId);
							if (subItem != null)
							{
								GetExpandedRecipe(subItem.Symbol, level + 1, (int)item.Recipe.Demands[i].Count);
							}
							else
							{
								//Console.WriteLine(new string(' ', (level + 1) * 2) + item.Recipe.Demands[i].Count + " - Unknown Item #" + item.Recipe.Demands[i].ArchetypeId);
							}
						}
					}
				}

				return result;
			}

			private static string QuoteIt(string val)
			{
				return "\"" + val + "\"";
			}
		}
	}
}
