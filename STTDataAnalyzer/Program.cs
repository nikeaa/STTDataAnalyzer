using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using STTDataAnalyzer.ExtensionMethods;
using STTDataAnalyzer.Models;
using STTDataAnalyzer.SttUser;

namespace STTDataAnalyzer
{
	public class Program
	{
		//private static SttUser.Welcome sttUser;

		private static void Main(string[] args)
		{
			string data = File.ReadAllText(@"C:\Users\nikea\Desktop\STT\Crew.json");
			Welcome sttUser = Welcome.FromJson(data);
			List<DataCoreCrew> dataCoreCrew = readDataCoreCrew(@"C:\Users\nikea\Desktop\STT\STT - Crew.tsv");
			List<DataCoreItem> dataCoreItems = readDataCoreItems(@"C:\Users\nikea\Desktop\STT\STT - Items.tsv");
			List<DataCoreShip> dataCoreShips = readDataCoreShips(@"C:\Users\nikea\Desktop\STT\STT - Ships.tsv");
			List<DataCoreEquipment> dataCoreEquipment = readDataCoreEquipment(@"C:\Users\nikea\Desktop\STT\STT - Equipment.tsv");

			var x = dataCoreCrew.Where(dcc => dcc.Name == "Age of Sail Data");


			// *** Traits for a crew ***
			//Crew x = sttUser.Player.Character.Crew
			//.Where(c => c.Name == "Dr. Leonard McCoy")
			//.Select(c => c)
			//.FirstOrDefault();
			//foreach (string trait in x.Traits) {
			//	Console.WriteLine(trait);
			//}
			// *** End Traits for a crew ***

			// *** Crew with a trait ***
			//sttUser.Player.Character.Crew
			//.Where(c => c.Traits.Contains("borg"))
			//.ForEach(c => Console.WriteLine(c.Name));
			//Console.WriteLine();
			// *** End Crew with a trait ***

			// *** Voyagers with a specific trait and > 0 in two skills and with a specific skill ***
			//string primarySkill = "ScienceSkill";
			//string secondarySkill = "MedicineSkill";
			//string voyageSlotSkill = "MedicineSkill";
			//string trait = "doctor";
			//sttUser.Player.Character.Crew
			//.Where(c => c.VoyageScoreForSkillPair(primarySkill, secondarySkill, false) > 0 && c.VoyageScores[voyageSlotSkill] > 0 && c.Traits.Contains(trait))
			//.OrderByDescending(c => c.VoyageScoreForSkillPair(primarySkill, secondarySkill, false))
			//.Take(10)
			//.ForEach(c => Console.WriteLine(c.Name + " (" + c.Rarity + "/" + c.MaxRarity + ") - " + c.VoyageScoreForSkillPair(primarySkill, secondarySkill, false)));
			// ***End Voyagers with a specific trait and 2000+ in two skills ***

			// *** Top ten voyagers by skill pair ***
			//string primarySkill = "EngineeringSkill";
			//string secondarySkill = "DiplomacySkill";
			//sttUser.Player.Character.Crew.OrderByDescending(c => c.VoyageScoreForSkillPair(primarySkill, secondarySkill)).Take(10).ForEach(c => Console.WriteLine(c.Name + " (" + c.Rarity + "/" + c.MaxRarity + ") - " + c.VoyageScoreForSkillPair(primarySkill, secondarySkill)));
			//Console.WriteLine();
			//sttUser.Player.Character.Crew.OrderByDescending(c => c.VoyageScoreForSkillPair(primarySkill, secondarySkill, true)).Take(10).ForEach(c => Console.WriteLine(c.Name + " (" + c.Rarity + "/" + c.MaxRarity + ") - " + c.VoyageScoreForSkillPair(primarySkill, secondarySkill, true)));
			// *** End Top ten voyagers by skill pair ***

			// *** Order golds by tier ***
			dataCoreCrew.Where(c => c.MaxRarity == 5 && c.Have == true && c.Rarity != c.MaxRarity && c.Level != 100).OrderBy(c => c.Tier).ForEach(c => Console.WriteLine(c.Name + " - T" + c.Tier.ToString() + ", " + c.Rarity));
			// *** End Order golds by tier ***

			// *** Select crew with specific trait and voyage pair above specific value ***

			//List<Archetype> archetypes = sttUser.ItemArchetypeCache.Archetypes; // archetypes for needed items???

			//Player player = sttUser.Player;
			//Character character = player.Character;
			//Crew[] crew = character.Crew.ToArray(); // my crew

			//List<Item> items = character.Items; // my inventory


			// *** Find items that can't be obtained in space battles ***
			//sttUser.ItemArchetypeCache.GetItemsNotInSpaceBattles().ForEach(i => Console.WriteLine(i.Name + " " + i.Rarity + "*"));
			// *** End Find items that can't be obtained in space battles ***

			//Console.WriteLine();
			//Console.WriteLine();

			// *** Find all SRs that are FF but not FE ***
			//sttUser.Player.Character.GetSRThatAreFFButNotFE().ForEach(c => Console.WriteLine(c.Name + " - " + c.Level + "/" + c.Equipment.Count));
			// *** End Find all SRs that are FF but not FE ***

			//Console.WriteLine();
			//Console.WriteLine();

			// *** Find all SRs that are 3* ***
			//sttUser.Player.Character.GetSRThatAreThreeStar().ForEach(c => Console.WriteLine(c.Name + " - " + c.Level + "/" + c.Equipment.Count));
			// *** End Find all SRs that are 3* ***

			//Console.WriteLine();
			//Console.WriteLine();

			// *** Calculate Honor Debt ***
			//int honorDebt = sttUser.Player.Character.GetHonorDebt();
			//Console.WriteLine("Honor Debt = " + honorDebt);
			// *** End Calculate Honor Debt ***

			// *** Calculate items left to FE ***
			//var itemsLeftToFE = sttUser.Player.Character.GetItemsLeftToFE("seven_silver_crew");
			// *** End Calculate items left to FE ***

			// *** Export Archetypes spreadsheet ***
			//sttUser.ItemArchetypeCache.WriteArchetypesSpreadsheet("archetypes.csv");

			//Console.WriteLine("\r\nArchetypes CSV written.");
			// *** End Export Archetypes spreadsheet ***

			// *** Count Immortalized ***
			//Console.WriteLine("\r\nImmortialized Count: " + character.StoredImmortals.Count);
			//Console.WriteLine();
			// *** End Count Immortalized ***

			// *** Calculate voyage time ***
			//DateTime start = DateTime.Now;
			//int totalTime = Welcome.GetVoyageTimeEstimate(12735, 12351, 8556, 5844, 5195, 2152, 2825);
			//Console.WriteLine("\r\nvoyage time = " + (totalTime / 1000).ToHoursMinutes()); // 1000 is the default for the number of iterations.
			//DateTime end = DateTime.Now;
			//TimeSpan elapsed = end - start;
			//Console.WriteLine("elapsed time = " + elapsed.ToString());
			//Console.WriteLine();
			// *** End Calculate voyage time ***			

			// *** Voyage Calculator ***
			//start = DateTime.Now;
			//var voyageCrew = sttUser.Player.Character.GetVoyageCrew();
			//voyageCrew.Item1.ForEach(vc => Console.WriteLine(vc.Name));
			//voyageCrew.Item2.ForEach(vc => Console.WriteLine(vc));
			//end = DateTime.Now;
			//elapsed = end - start;
			//Console.WriteLine("\r\nelapsed time = " + elapsed.ToString());
			//totalTime = Welcome.GetVoyageTimeEstimate(voyageCrew.Item2[4], voyageCrew.Item2[0], voyageCrew.Item2[1], voyageCrew.Item2[5], voyageCrew.Item2[3], voyageCrew.Item2[2], 2800);
			//Console.WriteLine("\r\nvoyage time = " + (totalTime / 1000).ToHoursMinutes()); // 1000 is the default for the number of iterations.
			// *** End Voyage Calculaor ***

			// *** Find crew with two specific skills ***
			//sttUser.Player.Character.GetCrewWithTwoSpecificSkills("EngineeringSkill", "DiplomacySkill").OrderByDescending(c => c.EngineeringVoyageScore + c.DiplomacyVoyageScore).ForEach(c => Console.WriteLine(c.Name + " - " + c.EngineeringVoyageScore + "/" + c.DiplomacyVoyageScore + " (" + c.Rarity + "/" + c.MaxRarity + ")"));
			// *** End Find crew with two specific skills ***

			// *** Various playing around to figure out the data ***
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
			// *** End Various playing around to figure out the data ***

			Console.WriteLine("\r\nDone");
		}

		private static List<DataCoreEquipment> readDataCoreEquipment(string filePath)
		{
			List<DataCoreEquipment> result = new List<DataCoreEquipment>();
			string[] firstLine = null;
			bool isFirstLine = true;

			foreach (var line in File.ReadLines(filePath))
			{
				if (isFirstLine)
				{
					firstLine = line.Split('\t');
					isFirstLine = false;
				}
				else
				{
					string[] tempLine = line.Split('\t');

					DataCoreEquipment equipment = new DataCoreEquipment();
					equipment.CraftCost = int.Parse(tempLine[2]);
					equipment.Level = int.Parse(tempLine[1]);
					equipment.Name = tempLine[0];

					equipment.ItemsNeeded = new List<(string, int)>();
					for (int i =3; i < 26 * 13 + 9 + 1; i++) {
						if (tempLine[i] != "0") {
							equipment.ItemsNeeded.Add((firstLine[i], int.Parse(tempLine[i])));
						}
					}

					result.Add(equipment);
				}
			}

			return result;
		}

		private static List<DataCoreShip> readDataCoreShips(string filePath)
		{
			List<DataCoreShip> result = new List<DataCoreShip>();
			string[] firstLine = null;
			bool isFirstLine = true;
			List<string> multiwordTraits = new List<string>() { "Cloaking Device", "Transwarp Drive", "Electromagnetic Pulse", "War Veteran", "Spore Drive", "Orion Syndicate" };

			foreach (var line in File.ReadLines(filePath))
			{
				if (isFirstLine)
				{
					firstLine = line.Split('\t');
					isFirstLine = false;
				}
				else
				{
					string[] tempLine = line.Split('\t');

					DataCoreShip ship = new DataCoreShip();
					ship.Accuracy = int.Parse(tempLine[5]);
					ship.Antimatter = int.Parse(tempLine[4]);
					ship.Attack = int.Parse(tempLine[6]);
					ship.AttacksPerSecond = decimal.Parse(tempLine[7]);
					ship.CritBonus = int.Parse(tempLine[8]);
					ship.CritChance = int.Parse(tempLine[9]);
					ship.Evasion = int.Parse(tempLine[10]);
					ship.Hull = int.Parse(tempLine[11]);
					ship.Level = int.Parse(tempLine[3].Split('/')[0]);
					ship.MaxLevel = int.Parse(tempLine[3].Split('/')[1]);
					ship.Name = tempLine[0];
					ship.Owned = tempLine[1] == "TRUE";
					ship.Rarity = int.Parse(tempLine[2]);
					ship.Shields = int.Parse(tempLine[12]);
					ship.ShieldRegen = int.Parse(tempLine[13]);

					ship.Traits = new List<string>();
					string traits = tempLine[14];
					foreach (string multiwordTrait in multiwordTraits)
					{
						if (traits.Contains(multiwordTrait))
						{
							ship.Traits.Add(multiwordTrait);
							traits.Replace(multiwordTrait, "");
						}
					}
					traits = traits.Replace("  ", " ");

					ship.Traits.AddRange(traits.Split(' '));
					
					result.Add(ship);
				}
			}

			return result;
		}

		private static List<DataCoreItem> readDataCoreItems(string filePath)
		{
			List<DataCoreItem> result = new List<DataCoreItem>();
			string[] firstLine = null;
			bool isFirstLine = true;

			foreach (var line in File.ReadLines(filePath))
			{
				if (isFirstLine)
				{
					firstLine = line.Split('\t');
					isFirstLine = false;
				}
				else
				{
					string[] tempLine = line.Split('\t');

					DataCoreItem item = new DataCoreItem();
					item.Flavor = tempLine[4];
					item.Image = tempLine[7];
					item.Name = tempLine[0];
					item.Quantity = int.Parse(tempLine[2]);
					item.Rarity = int.Parse(tempLine[1]);
					item.Symbol = tempLine[5];
					item.Type = int.Parse(tempLine[3]);
					item.Bonuses = JsonConvert.DeserializeObject<Dictionary<string, int>>(tempLine[6]);

					result.Add(item);
				}
			}
			return result;
		}

		private static List<DataCoreCrew> readDataCoreCrew(string filePath)
		{
			List<DataCoreCrew> result = new List<DataCoreCrew>();
			string[] firstLine = null;
			bool isFirstLine = true;

			foreach (var line in File.ReadLines(filePath))
			{
				if (isFirstLine)
				{
					firstLine = line.Split('\t');
					isFirstLine = false;
				}
				else
				{
					string[] tempLine = line.Split('\t');

					DataCoreCrew crew = new DataCoreCrew();

					crew.Accuracy = !string.IsNullOrEmpty(tempLine[43]) ? int.Parse(tempLine[43]) : 0;
					crew.Action = new DataCoreCrewAction();
					crew.Action.Amount = int.Parse(tempLine[34]);
					crew.Action.Boosts = tempLine[33];
					crew.Action.Cooldown = int.Parse(tempLine[37]);
					crew.Action.Duration = int.Parse(tempLine[36]);
					crew.Action.Initialize = int.Parse(tempLine[35]);
					crew.Action.Name = tempLine[0];
					crew.Bonus = new DataCoreCrewBonus();
					crew.Bonus.Ability = tempLine[38];
					crew.Bonus.HandicapAmount = !string.IsNullOrEmpty(tempLine[42]) ? int.Parse(tempLine[42]) : 0;
					crew.Bonus.HandicapType = tempLine[41];
					crew.Bonus.Trigger = tempLine[39];
					crew.Bonus.UsesPerBattle = !string.IsNullOrEmpty(tempLine[40]) ? int.Parse(tempLine[40]) : 0;
					crew.ChargePhases = tempLine[47];
					crew.Collections = new List<string>();
					if (!string.IsNullOrEmpty(tempLine[10])) {
						crew.Collections = tempLine[10].Split('.').ToList();
					}
					crew.CritBonus = !string.IsNullOrEmpty(tempLine[44]) ? int.Parse(tempLine[44]) : 0;
					crew.CritRating = !string.IsNullOrEmpty(tempLine[45]) ? int.Parse(tempLine[45]) : 0;
					crew.Equipment = tempLine[7];
					crew.Evasion = !string.IsNullOrEmpty(tempLine[46]) ? int.Parse(tempLine[46]) : 0;
					crew.GauntletRank = int.Parse(tempLine[12]);
					crew.Have = tempLine[1] == "TRUE";
					crew.Immortal = int.Parse(tempLine[6]);
					crew.InPortal = tempLine[9] == "TRUE";
					crew.Level = int.Parse(tempLine[5]);
					crew.MaxRarity = int.Parse(tempLine[3]);
					crew.Name = tempLine[0];
					crew.Rarity = int.Parse(tempLine[4]);
					crew.ShortName = tempLine[2];
					crew.Skills = new Dictionary<string, (int, int, int)>();
					crew.Skills.Add("CommandSkill", (int.Parse(tempLine[13]), int.Parse(tempLine[14]), int.Parse(tempLine[15])));
					crew.Skills.Add("DiplomacySkill", (int.Parse(tempLine[16]), int.Parse(tempLine[17]), int.Parse(tempLine[18])));
					crew.Skills.Add("EngineeringSkill", (int.Parse(tempLine[19]), int.Parse(tempLine[20]), int.Parse(tempLine[21])));
					crew.Skills.Add("MedicineSkill", (int.Parse(tempLine[22]), int.Parse(tempLine[23]), int.Parse(tempLine[24])));
					crew.Skills.Add("ScienceSkill", (int.Parse(tempLine[25]), int.Parse(tempLine[26]), int.Parse(tempLine[27])));
					crew.Skills.Add("SecuritySkill", (int.Parse(tempLine[28]), int.Parse(tempLine[29]), int.Parse(tempLine[30])));
					crew.Tier = !string.IsNullOrEmpty(tempLine[8]) ? int.Parse(tempLine[8]) : 0;
					crew.Traits = JsonConvert.DeserializeObject<List<string>>(tempLine[31]);
					crew.VoyageRank = int.Parse(tempLine[11]);

					result.Add(crew);
				}
			}

			return result;
		}
	}
}
