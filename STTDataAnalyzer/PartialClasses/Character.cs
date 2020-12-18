using System;
using System.Collections.Generic;
using System.Linq;

namespace STTDataAnalyzer
{
	namespace SttUser
	{
		public partial class Character
		{
			public IOrderedEnumerable<Crew> GetSRThatAreFFButNotFE()
			{
				return Crew.Where(c => c.MaxRarity == 4 && c.Rarity == 4 && (c.Level < 100 || (c.Level == 100 && c.Equipment.Count < 4))).OrderByDescending(c => c.Level).ThenByDescending(c => c.Equipment.Count);
			}

			public IOrderedEnumerable<Crew> GetSRThatAreThreeStar()
			{
				return Crew.Where(c => c.MaxRarity == 4 && c.Rarity == 3).OrderByDescending(c => c.Level).ThenByDescending(c => c.Equipment.Count);
			}

			public int GetHonorDebt()
			{
				return Crew.Where(c => c.MaxRarity != c.Rarity).Sum(c =>
				{
					switch (c.MaxRarity)
					{
						case 2:
							return 500;
						case 3:
							return (int)(4500 * (c.MaxRarity - c.Rarity));
						case 4:
							return (int)(18000 * (c.MaxRarity - c.Rarity));
						case 5:
							return (int)(50000 * (c.MaxRarity - c.Rarity));
						default:
							return 0;
					}
				});
			}

			public IEnumerable<Item> GetItemsLeftToFE(string characterSymbol)
			{
				//Crew sevenInSilver = crew.Where(c => c.Symbol == "seven_silver_crew").Select(c => c).FirstOrDefault();
				return null;
			}

			public IEnumerable<Crew> GetCrewWithTwoSpecificSkills(string primarySkill, string secondarySkill) {
				return Crew.Where(c => c.VoyageScores[primarySkill] > 0 && c.VoyageScores[secondarySkill] > 0).Select(c => c);
			}

			public (Crew[], int[]) GetVoyageCrew()
			{
				const int voyageCrewSlotCount = 12;

				// Gather voyage info.
				VoyageDescription voyageInfo = VoyageDescriptions[0];
				string primarySkill = voyageInfo.Skills.PrimarySkill.ToString();
				string secondarySkill = voyageInfo.Skills.SecondarySkill.ToString();
				//Console.WriteLine(primarySkill + "/" + secondarySkill);
				CrewSlot[] voyageCrewSlots = voyageInfo.CrewSlots.ToArray();

				CrewMember[] crewScores = CalcualteCrewVoyageSkillValues(Crew.ToArray(), primarySkill, secondarySkill, voyageCrewSlots);

				int commandTotal = 0;
				int diplomacyTotal = 0;
				int engineeringTotal = 0;
				int medicineTotal = 0;
				int scienceTotal = 0;
				int securityTotal = 0;

				string[] populatedSlotNames = new string[voyageCrewSlotCount];
				Crew[] populatedSlotCrews = new Crew[voyageCrewSlotCount];

				// fill all the voyage seats
				for (int voyageSlotIndex = 0; voyageSlotIndex < voyageCrewSlotCount; voyageSlotIndex++)
				{
					GetUnusedCrewForVoyageSeat(crewScores, populatedSlotNames, populatedSlotCrews, voyageSlotIndex);
					//Console.WriteLine(populatedSlotNames[voyageSlotIndex]);

					if (populatedSlotCrews[voyageSlotIndex].BaseSkills.CommandSkill != null)
						commandTotal += populatedSlotCrews[voyageSlotIndex].CommandVoyageScore; // (int)(populatedSlotCrews[voyageSlotIndex].BaseSkills.CommandSkill.Core + ((populatedSlotCrews[voyageSlotIndex].BaseSkills.CommandSkill.RangeMin + populatedSlotCrews[voyageSlotIndex].BaseSkills.CommandSkill.RangeMax) / 2));
					if (populatedSlotCrews[voyageSlotIndex].BaseSkills.DiplomacySkill != null)
						diplomacyTotal += populatedSlotCrews[voyageSlotIndex].DiplomacyVoyageScore; //  (int)(populatedSlotCrews[voyageSlotIndex].BaseSkills.DiplomacySkill.Core + ((populatedSlotCrews[voyageSlotIndex].BaseSkills.DiplomacySkill.RangeMin + populatedSlotCrews[voyageSlotIndex].BaseSkills.DiplomacySkill.RangeMax) / 2));
					if (populatedSlotCrews[voyageSlotIndex].BaseSkills.EngineeringSkill != null)
						engineeringTotal += populatedSlotCrews[voyageSlotIndex].EngineeringVoyageScore; // (int)(populatedSlotCrews[voyageSlotIndex].BaseSkills.EngineeringSkill.Core + ((populatedSlotCrews[voyageSlotIndex].BaseSkills.EngineeringSkill.RangeMin + populatedSlotCrews[voyageSlotIndex].BaseSkills.EngineeringSkill.RangeMax) / 2));
					if (populatedSlotCrews[voyageSlotIndex].BaseSkills.MedicineSkill != null)
						medicineTotal += populatedSlotCrews[voyageSlotIndex].MedicineVoyageScore; // (int)(populatedSlotCrews[voyageSlotIndex].BaseSkills.MedicineSkill.Core + ((populatedSlotCrews[voyageSlotIndex].BaseSkills.MedicineSkill.RangeMin + populatedSlotCrews[voyageSlotIndex].BaseSkills.MedicineSkill.RangeMax) / 2));
					if (populatedSlotCrews[voyageSlotIndex].BaseSkills.ScienceSkill != null)
						scienceTotal += populatedSlotCrews[voyageSlotIndex].ScienceVoyageScore; // (int)(populatedSlotCrews[voyageSlotIndex].BaseSkills.ScienceSkill.Core + ((populatedSlotCrews[voyageSlotIndex].BaseSkills.ScienceSkill.RangeMin + populatedSlotCrews[voyageSlotIndex].BaseSkills.ScienceSkill.RangeMax) / 2));
					if (populatedSlotCrews[voyageSlotIndex].BaseSkills.SecuritySkill != null)
						securityTotal += populatedSlotCrews[voyageSlotIndex].SecurityVoyageScore; // (int)(populatedSlotCrews[voyageSlotIndex].BaseSkills.SecuritySkill.Core + ((populatedSlotCrews[voyageSlotIndex].BaseSkills.SecuritySkill.RangeMin + populatedSlotCrews[voyageSlotIndex].BaseSkills.SecuritySkill.RangeMax) / 2));
				}

				//Console.WriteLine();
				//Console.WriteLine("command = " + commandTotal);
				//Console.WriteLine("diplomacy = " + diplomacyTotal);
				//Console.WriteLine("engineering = " + engineeringTotal);
				//Console.WriteLine("medicine = " + medicineTotal);
				//Console.WriteLine("science = " + scienceTotal);
				//Console.WriteLine("security = " + securityTotal);

				// TODO: make adjustments to voyage crew selected if lowest score it too low.
				AdjustLowSkillValues(commandTotal, diplomacyTotal, engineeringTotal, medicineTotal, scienceTotal, securityTotal, Crew.ToArray(), populatedSlotNames, populatedSlotCrews, voyageCrewSlots);

				int[] skillTotals = new int[] { commandTotal, diplomacyTotal, engineeringTotal, medicineTotal, scienceTotal, securityTotal };

				return (populatedSlotCrews, skillTotals);
			}

			private static void GetUnusedCrewForVoyageSeat(CrewMember[] crewScores, string[] populatedSlotNames, Crew[] populatedSlotCrews, int v)
			{
				var sortedSlots = crewScores.OrderByDescending(x => x.VoyageScores[v]).Select(x => new { x.Crew, Score = x.VoyageScores[v] }).Take(50);

				foreach (var crewMember in sortedSlots)
				{
					if (!populatedSlotNames.Contains(crewMember.Crew.Name))
					{
						populatedSlotNames[v] = crewMember.Crew.Name;
						populatedSlotCrews[v] = crewMember.Crew;
						break;
					}
				}
			}

			private static CrewMember[] CalcualteCrewVoyageSkillValues(Crew[] crew, string primarySkill, string secondarySkill, CrewSlot[] voyageCrewSlots)
			{
				int crewCount = crew.Count();
				CrewMember[] crewScores = new CrewMember[crewCount];

				// Calculate voyage scores for each crew for each skill
				for (int crewIndex = 0; crewIndex < crew.Count(); crewIndex++)
				{
					Crew crewMember = crew[crewIndex];
					crewScores[crewIndex] = new CrewMember(crewMember);
					for (int voyageSlotIndex = 0; voyageSlotIndex < voyageCrewSlots.Count(); voyageSlotIndex++)
					{
						CrewSlot voyageCrewSlot = voyageCrewSlots[voyageSlotIndex];

						int totalScore = 0;
						if (crewMember.HasSkillForVoyageSlot(voyageCrewSlot))
						{
							if (crewMember.BaseSkills.CommandSkill != null) totalScore += GetSkillVoyageScore(crewMember, primarySkill, secondarySkill, "CommandSkill", voyageCrewSlot.Trait);
							if (crewMember.BaseSkills.DiplomacySkill != null) totalScore += GetSkillVoyageScore(crewMember, primarySkill, secondarySkill, "DiplomacySkill", voyageCrewSlot.Trait);
							if (crewMember.BaseSkills.EngineeringSkill != null) totalScore += GetSkillVoyageScore(crewMember, primarySkill, secondarySkill, "EngineerSkill", voyageCrewSlot.Trait);
							if (crewMember.BaseSkills.MedicineSkill != null) totalScore += GetSkillVoyageScore(crewMember, primarySkill, secondarySkill, "MedicineSkill", voyageCrewSlot.Trait);
							if (crewMember.BaseSkills.ScienceSkill != null) totalScore += GetSkillVoyageScore(crewMember, primarySkill, secondarySkill, "ScienceSkill", voyageCrewSlot.Trait);
							if (crewMember.BaseSkills.SecuritySkill != null) totalScore += GetSkillVoyageScore(crewMember, primarySkill, secondarySkill, "SecuritySkill", voyageCrewSlot.Trait);
						}

						crewScores[crewIndex].VoyageScores[voyageSlotIndex] = totalScore;
					}
				}

				return crewScores;
			}

			private static void AdjustLowSkillValues(int commandTotal, int diplomacyTotal, int engineeringTotal, int medicineTotal, int scienceTotal, int securityTotal, Crew[] crew, string[] populatedSlotNames, Crew[] populatedSlotCrews, CrewSlot[] voyageCrewSlots)
			{
				int minimumSkillValue = 3000;

				if (commandTotal < minimumSkillValue)
				{
					// adjust command up to 3000+
				}
				if (diplomacyTotal < minimumSkillValue)
				{
					// adjust diplomacy up to 3000+
				}
				if (engineeringTotal < minimumSkillValue)
				{
					// adjust engineering up to 3000+
				}
				if (medicineTotal < minimumSkillValue)
				{
					// adjust medicine up to 3000+
				}
				if (scienceTotal < minimumSkillValue)
				{
					// adjust science up to 3000+
				}
				if (securityTotal < minimumSkillValue)
				{
					// adjust security up to 3000+
				}
				return;
			}

			private static int GetSkillVoyageScore(Crew crewMember, string primarySkill, string secondarySkill, string currentSkill, string trait)
			{
				//double skillScore = GetSkillVoyageValue(crewMember, currentSkill);
				double skillScore = crewMember.VoyageScores[primarySkill];
				if (primarySkill == currentSkill) skillScore *= 0.500;
				else if (secondarySkill == currentSkill) skillScore *= 0.358;
				else skillScore *= 0.100;

				if (crewMember.Traits.Contains(trait)) skillScore += 25;

				return (int)skillScore;
			}

			//private static double GetSkillVoyageValue(Crew crewMember, string primarySkill)
			//{
			//	double skillValue = 0;

			//	skillValue = crewMember.VoyageScores[primarySkill];
				//switch (primarySkill)
				//{
				//	case "CommandSkill":
				//		skillValue = crewMember.CommandVoyageScore; // crewMember.BaseSkills.CommandSkill.Core + ((crewMember.BaseSkills.CommandSkill.RangeMin + crewMember.BaseSkills.CommandSkill.RangeMax) / 2);
				//		break;
				//	case "DiplomacySkill":
				//		skillValue = crewMember.DiplomacyVoyageScore; //  crewMember.BaseSkills.DiplomacySkill.Core + ((crewMember.BaseSkills.DiplomacySkill.RangeMin + crewMember.BaseSkills.DiplomacySkill.RangeMax) / 2);
				//		break;
				//	case "EngineeringSkill":
				//		skillValue = crewMember.EngineeringVoyageScore; // crewMember.BaseSkills.EngineeringSkill.Core + ((crewMember.BaseSkills.EngineeringSkill.RangeMin + crewMember.BaseSkills.EngineeringSkill.RangeMax) / 2);
				//		break;
				//	case "MedicineSkill":
				//		skillValue = crewMember.MedicineVoyageScore; // crewMember.BaseSkills.MedicineSkill.Core + ((crewMember.BaseSkills.MedicineSkill.RangeMin + crewMember.BaseSkills.MedicineSkill.RangeMax) / 2);
				//		break;
				//	case "ScienceSkill":
				//		skillValue = crewMember.ScienceVoyageScore; //  crewMember.BaseSkills.ScienceSkill.Core + ((crewMember.BaseSkills.ScienceSkill.RangeMin + crewMember.BaseSkills.ScienceSkill.RangeMax) / 2);
				//		break;
				//	case "SecuritySkill":
				//		skillValue = crewMember.SecurityVoyageScore; //  crewMember.BaseSkills.SecuritySkill.Core + ((crewMember.BaseSkills.SecuritySkill.RangeMin + crewMember.BaseSkills.SecuritySkill.RangeMax) / 2);
				//		break;
				//}

			//	return skillValue;
			//}
		}
	}
}
