using System;
using System.Collections.Generic;
using System.Linq;

namespace STTDataAnalyzer
{
	public class Program
	{
		private static SttUser.Welcome sttUser;

		private static void Main(string[] args)
		{
			string data = System.IO.File.ReadAllText(@"C:\Users\nikea\Desktop\Crew.json");
			sttUser = SttUser.Welcome.FromJson(data);

			List<SttUser.Crew> crew = sttUser.Player.Character.Crew;
			List<SttUser.VoyageDescription> voyageInfo = sttUser.Player.Character.VoyageDescriptions;
			List<SttUser.CrewSlot> voyageCrewSlots = voyageInfo[0].CrewSlots;
			//var items = sttUser.ItemArchetypeCache.Archetypes;
			//foreach (var iitem in items)
			//{
			//	Console.WriteLine(iitem.Id + " - " + iitem.Name + " (" + iitem.Rarity + ")");
			//}

			//IEnumerable<SttUser.Crew> crews = sttUser.Player.Character.Crew.Where(t => t.Name == "Covert Operative Leland");
			//foreach (SttUser.Crew crew in crews.Where(t => t.Level < 100))
			//{
			//	Console.Write(crew.Name + " - ");
			//	var x = crew.Equipment;
			//	for (int i = 0; i < 4; i++)
			//	{
			//		if (!x.Select(t => t).Any(t => t[1] == crew.EquipmentSlots[i].Archetype))
			//		{
			//			Console.Write(sttUser.ItemArchetypeCache.Archetypes.Where(t => t.Id == crew.EquipmentSlots[i].Archetype).SingleOrDefault().Name + "; ");
			//		}
			//	}
			//	Console.WriteLine();
			//}

			//var item = sttUser.ItemArchetypeCache.Archetypes.Find(a => a.Name == "Leland's Covert Operative Outfit" && a.Rarity == 4);

			//DisplayRecipe(item, 0, 1);

			//for (int i = 0; i < item0.Recipe.Demands.Count; i++){
			//	Console.WriteLine("Id = " + item0.Recipe.Demands[i].ArchetypeId);
			//	var item00 = welcome.ItemArchetypeCache.Archetypes.Find(a => a.Id == item0.Recipe.Demands[i].ArchetypeId);
			//	Console.WriteLine("Name = " + item0.Recipe.Demands[i].Count + " - " + item00.Name);
			//}

			//var item1 = welcome.ItemArchetypeCache.Archetypes.Find(a => a.Id == 6360);
			//for (int i = 0; i < item1.Recipe.Demands.Count; i++)
			//{
			//	Console.WriteLine("Id = " + item1.Recipe.Demands[i].ArchetypeId);
			//	var item11 = welcome.ItemArchetypeCache.Archetypes.Find(a => a.Id == item1.Recipe.Demands[i].ArchetypeId);
			//	Console.WriteLine("Name = " + item1.Recipe.Demands[i].Count + " - " + item11.Name);
			//}

			//Console.WriteLine(item0.Id);
			//Console.WriteLine(item0.Name);

			//Console.WriteLine(item0.Recipe.Demands[0].ArchetypeId);
			//var item00 = welcome.ItemArchetypeCache.Archetypes.Find(a => a.Id == item0.Recipe.Demands[0].ArchetypeId);
			//Console.WriteLine(item00.Name);
			//Console.WriteLine(item0.Recipe.Demands[1].ArchetypeId);
			//Console.WriteLine(item0.Recipe.Demands[2].ArchetypeId);
			//Console.WriteLine();

			//var item1 = welcome.ItemArchetypeCache.Archetypes.Find(a => a.Name == "Authorization Code");
			//Console.WriteLine(item1.Id);

			Console.ReadLine();
		}

		private static void DisplayRecipe(SttUser.Archetype item, int level, int quantity)
		{
			Console.WriteLine(new string(' ', level * 2) + quantity + " - " + item.Name + " " + new string('*', (int)item.Rarity));
			if (item.Recipe != null)
			{
				for (int i = 0; i < item.Recipe.Demands.Count; i++)
				{
					var subItem = sttUser.ItemArchetypeCache.Archetypes.Find(a => a.Id == item.Recipe.Demands[i].ArchetypeId);
					if (subItem != null)
					{
						DisplayRecipe(subItem, level + 1, (int)item.Recipe.Demands[i].Count);
					}
					else
					{
						Console.WriteLine(new string(' ', (level + 1) * 2) + item.Recipe.Demands[i].Count + " - Unknown Item #" + item.Recipe.Demands[i].ArchetypeId);
					}
					//var item00 = sttUser.ItemArchetypeCache.Archetypes.Find(a => a.Id == item.Recipe.Demands[i].ArchetypeId);
					//Console.WriteLine("Name = " + item0.Recipe.Demands[i].Count + " - " + item00.Name);
				}
			}
		}
	}
}
