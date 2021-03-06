﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace STTDataAnalyzer.Models.DataCore
{
	public class DataCore
	{
		public List<DataCoreCrew> Crew = new List<DataCoreCrew>();
		public List<DataCoreEquipment> Equipment = new List<DataCoreEquipment>();
		public List<DataCoreItem> Items = new List<DataCoreItem>();
		public List<DataCoreShip> Ships = new List<DataCoreShip>();

		public string Path = ConfigurationManager.AppSettings["Path"];

		private const string CrewFileName = "STT - Crew.tsv";
		private const string EquipmentFileName = "STT - Equipment.tsv";
		private const string ItemsFileName = "STT - Items.tsv";
		private const string ShipsFileName = "STT - Ships.tsv";

		public DataCore(string crewFileName = CrewFileName, string equipmentFileName = EquipmentFileName, string itemsFileName = ItemsFileName, string shipsFileName = ShipsFileName)
		{
			ParseCrew(crewFileName);
			ParseEquipment(equipmentFileName);
			ParseItems(itemsFileName);
			ParseShips(shipsFileName);
		}

		public void ParseCrew(string fileName = CrewFileName)
		{
			string[] firstLine = null;
			bool isFirstLine = true;

			foreach (var line in File.ReadLines(Path + fileName))
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
					if (!string.IsNullOrEmpty(tempLine[10]))
					{
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

					Crew.Add(crew);
				}
			}
		}

		public void ParseEquipment(string fileName = EquipmentFileName)
		{
			string[] firstLine = null;
			bool isFirstLine = true;

			foreach (var line in File.ReadLines(Path + fileName))
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
					for (int i = 3; i < 26 * 13 + 9 + 1; i++)
					{
						if (tempLine[i] != "0")
						{
							equipment.ItemsNeeded.Add((firstLine[i], int.Parse(tempLine[i])));
						}
					}

					Equipment.Add(equipment);
				}
			}
		}

		public void ParseItems(string fileName = ItemsFileName)
		{
			string[] firstLine = null;
			bool isFirstLine = true;

			foreach (var line in File.ReadLines(Path + fileName))
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

					Items.Add(item);
				}
			}
		}

		public void ParseShips(string fileName = ShipsFileName)
		{
			string[] firstLine = null;
			bool isFirstLine = true;
			List<string> multiwordTraits = new List<string>() { "Cloaking Device", "Transwarp Drive", "Electromagnetic Pulse", "War Veteran", "Spore Drive", "Orion Syndicate" };

			foreach (var line in File.ReadLines(Path + fileName))
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

					Ships.Add(ship);
				}
			}
		}
	}
}
