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
			string primarySkill = "SecuritySkill";
			string secondarySkill = "MedicineSkill";

			string data = System.IO.File.ReadAllText(@"C:\Users\nikea\Desktop\Crew.json");
			sttUser = SttUser.Welcome.FromJson(data);

			SttUser.Crew[] crew = sttUser.Player.Character.Crew.ToArray();
			List<SttUser.VoyageDescription> voyageInfo = sttUser.Player.Character.VoyageDescriptions;
			SttUser.CrewSlot[] voyageCrewSlots = voyageInfo[0].CrewSlots.ToArray();

			int crewCount = crew.Count();
			int[,] crewScores = new int[crewCount,12];

			for (int i = 0; i < crew.Count(); i++) {
				SttUser.Crew crewMember = crew[i];
				for (int j = 0; j < voyageCrewSlots.Count(); j++)
				{
					SttUser.CrewSlot voyageCrewSlot = voyageCrewSlots[j];

					int totalScore = 0;
					if (crewMember.BaseSkills.CommandSkill != null) totalScore += GetSkillVoyageScore(crewMember, primarySkill, secondarySkill, "CommandSkill", voyageCrewSlot.Trait);
					if (crewMember.BaseSkills.DiplomacySkill != null) totalScore += GetSkillVoyageScore(crewMember, primarySkill, secondarySkill, "DiplomacySkill", voyageCrewSlot.Trait);
					if (crewMember.BaseSkills.EngineeringSkill != null) totalScore += GetSkillVoyageScore(crewMember, primarySkill, secondarySkill, "EngineerSkill", voyageCrewSlot.Trait);
					if (crewMember.BaseSkills.MedicineSkill.Core > 0) totalScore += GetSkillVoyageScore(crewMember, primarySkill, secondarySkill, "MedicineSkill", voyageCrewSlot.Trait);
					if (crewMember.BaseSkills.ScienceSkill.Core > 0) totalScore += GetSkillVoyageScore(crewMember, primarySkill, secondarySkill, "ScienceSkill", voyageCrewSlot.Trait);
					if (crewMember.BaseSkills.SecuritySkill.Core > 0) totalScore += GetSkillVoyageScore(crewMember, primarySkill, secondarySkill, "SecuritySkill", voyageCrewSlot.Trait);

					crewScores[i, j] = totalScore;
				}
			}
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

		private static int GetSkillVoyageScore(SttUser.Crew crewMember, string primarySkill, string secondarySkill, string currentSkill, string trait)
		{
			double skillScore = GetSkillVoyageValue(crewMember, currentSkill);
			if (primarySkill == currentSkill) skillScore *= 0.500;
			else if (secondarySkill == currentSkill) skillScore *= 0.358;
			else skillScore *= 0.100;

			if (crewMember.Traits.Contains(trait)) skillScore += 200;

			return (int)skillScore;
		}

		private static double GetSkillVoyageValue(SttUser.Crew crewMember, string primarySkill)
		{
			double skillValue = 0;

			switch(primarySkill) {
				case "CommandSkill":
					skillValue = crewMember.BaseSkills.CommandSkill.Core + ((crewMember.BaseSkills.CommandSkill.RangeMin + crewMember.BaseSkills.CommandSkill.RangeMax) / 2);
					break;
				case "DiplomacySkill":
					skillValue = crewMember.BaseSkills.DiplomacySkill.Core + ((crewMember.BaseSkills.DiplomacySkill.RangeMin + crewMember.BaseSkills.DiplomacySkill.RangeMax) / 2);
					break;
				case "EngineeringSkill":
					skillValue = crewMember.BaseSkills.EngineeringSkill.Core + ((crewMember.BaseSkills.EngineeringSkill.RangeMin + crewMember.BaseSkills.EngineeringSkill.RangeMax) / 2);
					break;
				case "MedicineSkill":
					skillValue = crewMember.BaseSkills.MedicineSkill.Core + ((crewMember.BaseSkills.MedicineSkill.RangeMin + crewMember.BaseSkills.MedicineSkill.RangeMax) / 2);
					break;
				case "ScienceSkill":
					skillValue = crewMember.BaseSkills.ScienceSkill.Core + ((crewMember.BaseSkills.ScienceSkill.RangeMin + crewMember.BaseSkills.ScienceSkill.RangeMax) / 2);
					break;
				case "SecuritySkill":
					skillValue = crewMember.BaseSkills.SecuritySkill.Core + ((crewMember.BaseSkills.SecuritySkill.RangeMin + crewMember.BaseSkills.SecuritySkill.RangeMax) / 2);
					break;
			}

			return skillValue;
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
