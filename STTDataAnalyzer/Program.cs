using System;
using System.Collections.Generic;
using System.Linq;
using STTDataAnalyzer.SttUser;

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
			CrewMember[] crewScores = new CrewMember[crewCount];

			for (int i = 0; i < crew.Count(); i++) {
				SttUser.Crew crewMember = crew[i];
				crewScores[i] = new CrewMember(crewMember);
				for (int j = 0; j < voyageCrewSlots.Count(); j++)
				{
					SttUser.CrewSlot voyageCrewSlot = voyageCrewSlots[j];

					int totalScore = 0;
					if (crewMember.HasSkillForVoyageSlot(voyageCrewSlot)) {
						if (crewMember.BaseSkills.CommandSkill != null) totalScore += GetSkillVoyageScore(crewMember, primarySkill, secondarySkill, "CommandSkill", voyageCrewSlot.Trait);
						if (crewMember.BaseSkills.DiplomacySkill != null) totalScore += GetSkillVoyageScore(crewMember, primarySkill, secondarySkill, "DiplomacySkill", voyageCrewSlot.Trait);
						if (crewMember.BaseSkills.EngineeringSkill != null) totalScore += GetSkillVoyageScore(crewMember, primarySkill, secondarySkill, "EngineerSkill", voyageCrewSlot.Trait);
						if (crewMember.BaseSkills.MedicineSkill != null) totalScore += GetSkillVoyageScore(crewMember, primarySkill, secondarySkill, "MedicineSkill", voyageCrewSlot.Trait);
						if (crewMember.BaseSkills.ScienceSkill != null) totalScore += GetSkillVoyageScore(crewMember, primarySkill, secondarySkill, "ScienceSkill", voyageCrewSlot.Trait);
						if (crewMember.BaseSkills.SecuritySkill != null) totalScore += GetSkillVoyageScore(crewMember, primarySkill, secondarySkill, "SecuritySkill", voyageCrewSlot.Trait);
					}

					crewScores[i].VoyageScores[j] = totalScore;
				}
			}


			int commandTotal = 0;
			int diplomacyTotal = 0;
			int engineeringTotal = 0;
			int medicineTotal = 0;
			int scienceTotal = 0;
			int securityTotal = 0;

			string[] populatedSlotNames = new string[12];
			SttUser.Crew[] populatedSlotCrews = new SttUser.Crew[12];

			for (int i = 0; i < 12; i++)
			{
				GetUnusedCrew(crewScores, populatedSlotNames, populatedSlotCrews, i);
				Console.WriteLine(populatedSlotNames[i]);

				commandTotal += (int)(populatedSlotCrews[i].BaseSkills.CommandSkill.Core + ((populatedSlotCrews[i].BaseSkills.CommandSkill.RangeMin + populatedSlotCrews[i].BaseSkills.CommandSkill.RangeMax) / 2));
				diplomacyTotal += (int)(populatedSlotCrews[i].BaseSkills.DiplomacySkill.Core + ((populatedSlotCrews[i].BaseSkills.DiplomacySkill.RangeMin + populatedSlotCrews[i].BaseSkills.DiplomacySkill.RangeMax) / 2));
				engineeringTotal += (int)(populatedSlotCrews[i].BaseSkills.EngineeringSkill.Core + ((populatedSlotCrews[i].BaseSkills.EngineeringSkill.RangeMin + populatedSlotCrews[i].BaseSkills.EngineeringSkill.RangeMax) / 2));
				medicineTotal += (int)(populatedSlotCrews[i].BaseSkills.MedicineSkill.Core + ((populatedSlotCrews[i].BaseSkills.MedicineSkill.RangeMin + populatedSlotCrews[i].BaseSkills.MedicineSkill.RangeMax) / 2));
				scienceTotal += (int)(populatedSlotCrews[i].BaseSkills.ScienceSkill.Core + ((populatedSlotCrews[i].BaseSkills.ScienceSkill.RangeMin + populatedSlotCrews[i].BaseSkills.ScienceSkill.RangeMax) / 2));
				securityTotal += (int)(populatedSlotCrews[i].BaseSkills.SecuritySkill.Core + ((populatedSlotCrews[i].BaseSkills.SecuritySkill.RangeMin + populatedSlotCrews[i].BaseSkills.SecuritySkill.RangeMax) / 2));
			}

			Console.WriteLine();
			Console.WriteLine("command = " + commandTotal);

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
			//	Console.WriteLine("Id = " + i
			//etypeCache.Archetypes.Find(a => a.Id == item1.Recipe.Demands[i].ArchetypeId);
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

			Console.WriteLine("Done");
			Console.ReadLine();
		}

		private static void GetUnusedCrew(CrewMember[] crewScores, string[] populatedSlotNames, Crew[] populatedSlotCrews, int v)
		{
			var sortedSlots = crewScores.OrderByDescending(x => x.VoyageScores[v]).Select(x => new { x.Crew, Score = x.VoyageScores[v] }).Take(50);

			foreach(var crewMember in sortedSlots) {
				if (!populatedSlotNames.Contains(crewMember.Crew.Name)){
					populatedSlotNames[v] = crewMember.Crew.Name;
					populatedSlotCrews[v] = crewMember.Crew;
					break;
				}
			}
		}

		private static int GetSkillVoyageScore(SttUser.Crew crewMember, string primarySkill, string secondarySkill, string currentSkill, string trait)
		{
			double skillScore = GetSkillVoyageValue(crewMember, currentSkill);
			if (primarySkill == currentSkill) skillScore *= 0.500;
			else if (secondarySkill == currentSkill) skillScore *= 0.358;
			else skillScore *= 0.100;

			if (crewMember.Traits.Contains(trait)) skillScore += 25;

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

	public class CrewMember : IComparable {
		public SttUser.Crew Crew;
		public int[] VoyageScores;

		public CrewMember(SttUser.Crew c) {
			this.Crew = c;
			this.VoyageScores = new int[12];
		}

		public int CompareTo(object obj)
		{
			if (obj == null) return 1;

			CrewMember cm = obj as CrewMember;
			if(cm != null) {
				if (this.VoyageScores[0] < cm.VoyageScores[0]) return -1;
				if (this.VoyageScores[0] > cm.VoyageScores[0]) return 1;
				return 0;
			}

			return 0;
		}
	}
}
