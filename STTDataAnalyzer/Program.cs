using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using STTDataAnalyzer.ExtensionMethods;
using STTDataAnalyzer.Models;
using STTDataAnalyzer.SttUser;
using System.Net;

namespace STTDataAnalyzer
{
	public class Program
	{
		//private static SttUser.Welcome sttUser;

		private static void Main(string[] args)
		{
			string data = File.ReadAllText(@"C:\Users\nikea\Desktop\STT\PlayerData.json");
			Welcome sttUser = Welcome.FromJson(data);
			List<DataCoreCrew> dataCoreCrew = readDataCoreCrew(@"C:\Users\nikea\Desktop\STT\STT - Crew.tsv");
			List<DataCoreItem> dataCoreItems = readDataCoreItems(@"C:\Users\nikea\Desktop\STT\STT - Items.tsv");
			List<DataCoreShip> dataCoreShips = readDataCoreShips(@"C:\Users\nikea\Desktop\STT\STT - Ships.tsv");
			List<DataCoreEquipment> dataCoreEquipment = readDataCoreEquipment(@"C:\Users\nikea\Desktop\STT\STT - Equipment.tsv");
			List<LevelTable> levelTables = JsonConvert.DeserializeObject<List<LevelTable>>(File.ReadAllText(@"C:\Users\nikea\Desktop\STT\LevelTables.json"));

			//using (WebClient client = new WebClient())
			//{
			//	string s = client.DownloadString("https://github.com/stt-datacore/website/tree/master/static/structured/");
			//}

			string staticBotCrew = GetStaticData<string>("botcrew.json"); 
			string staticCollections = GetStaticData<string>("collections.json"); 
			string staticCrew = GetStaticData<string>("crew.json");
			string staticDilemmas = GetStaticData<string>("dilemmas.json");
			string staticDisputes = GetStaticData<string>("disputes.json");
			string staticEpisodes = GetStaticData<string>("episodes.json");
			string staticEventFLeaderboards= GetStaticData<string>("event_fleaderboards.json");
			string staticEventInstances = GetStaticData<string>("event_instances.json");
			string staticEventLeaderboards = GetStaticData<string>("event_leaderboards.json");
			string staticFactions = GetStaticData<string>("factions.json");
			string staticItems = GetStaticData<string>("items.json");
			string staticKeystones = GetStaticData<string>("keystones.json");
			string staticMiscStats = GetStaticData<string>("misc_stats.json");
			string staticMissions = GetStaticData<string>("missions.json");
			string staticQuests = GetStaticData<string>("quests.json");
			string staticShipSchematics = GetStaticData<string>("ship_schematics.json");
			string staticSkillBuffs = GetStaticData<string>("skill_buffs.json");
			string staticUpcomingEvents = GetStaticData<string>("upcomingevents.json");

			Dictionary<string, (double, double, double)> buffs = sttUser.Player.Character.GetBuffs();

			//string wikiText = "<!-- Created from Template:Crew/add -->{{Infobox crew\\n |stars = 5\\n |CMD =  | DIP =  | ENG = 73 | SEC =  | SCI = 52 | MED = 31\\n <!--traits:-->| Caregiver| Desperate| Explorer| Musician| Nacene| Cultural Figure| Theoretical Engineer\\n |abil = eva\\n |char = Caretaker\\n |Row 6 title\t= Other Versions\\n |Row 6 info\t= [[Caretaker#Versions | Caretaker Versions]]\\n}} \\n\\n'''{{PAGENAME}}''' is a [[Legendary]] [5-star] [[crew]] member. \\n\\n{{PAGENAME}} is a version of the [[Caretaker]] from the [[VOY|''Star Trek: Voyager'']] episode [http://memory-alpha.wikia.com/wiki/Caretaker_%28episode%29 \"Caretaker\" (1x01)].\\n\\n{{CrewTOC|{{PAGENAME}}}}\\n\\n<div class=\"mobileclear\"></div><!-- Do not change to clear:both, this will shift page down if screen too narrow for tables as needed -->\\n\\n==Advancement==\\nThese [[items]] are required by {{PAGENAME}} in order to advance through groups of levels.\\n{| class=\"wikitable\"\\n|-\\n! style=\"font-size:75%;\" | Equip<br>Rank !! colspan=\"2\" | Equipment 1 !! colspan=\"2\" | Equipment 2 !! colspan=\"2\" | Equipment  3 !! colspan=\"2\" | Equipment 4\\n|-\\n! 0\\n| class=\"ItemRight\" | 1: || [[Caretaker's Outfit]]\\n| class=\"ItemRight\" | 2: || [[Biological Sample Kit]]\\n| class=\"ItemRight\" | 4: || [[Medical Experiment]] {{Stars|1}}\\n| class=\"ItemRight\" | 5: || [[Quantum Flux Regulator]] {{Stars|1}}\\n|-\\n! 1\\n| class=\"ItemRight\" | 10: || [[Caretaker's Outfit]] {{Stars|1}}\\n| class=\"ItemRight\" | 13: || [[Science Experiment]] {{Stars|1}}\\n| class=\"ItemRight\" | 16: || [[Astrometric Chart]] {{Stars|1}}\\n| class=\"ItemRight\" | 20: || [[Caretaker's Banjo]] {{Stars|2}}\\n|-\\n! 2\\n| class=\"ItemRight\" | 20: || [[Caretaker's Outfit]] {{Stars|2}}\\n| class=\"ItemRight\" | 23: || [[Psychological Evaluation Holoprogram]] {{Stars|1}}\\n| class=\"ItemRight\" | 26: || [[Quantum Flux Regulator]] {{Stars|2}}\\n| class=\"ItemRight\" | 30: || [[Biological Sample Kit]] {{Stars|2}}\\n|-\\n! 3\\n| class=\"ItemRight\" | 30: || [[Caretaker's Outfit]] {{Stars|2}}\\n| class=\"ItemRight\" | 33: || [[Astrometric Chart]] {{Stars|2}}\\n| class=\"ItemRight\" | 36: || [[Flux Coupler]] {{Stars|3}}\\n| class=\"ItemRight\" | 40: || [[Caretaker's Banjo]] {{Stars|2}}\\n|-\\n! 4\\n| class=\"ItemRight\" | 40: || [[Caretaker's Outfit]] {{Stars|3}}\\n| class=\"ItemRight\" | 43: || [[Medical Experiment]] {{Stars|3}}\\n| class=\"ItemRight\" | 46: || [[Engineering Lesson]] {{Stars|3}}\\n| class=\"ItemRight\" | 50: || [[Encoded Communique]] {{Stars|3}}\\n|-\\n! 5\\n| class=\"ItemRight\" | 50: || [[Caretaker's Outfit]] {{Stars|3}}\\n| class=\"ItemRight\" | 53: || [[Science Experiment]] {{Stars|4}}\\n| class=\"ItemRight\" | 56: || [[Flux Coupler]] {{Stars|3}}\\n| class=\"ItemRight\" | 60: || [[Caretaker's Banjo]] {{Stars|3}}\\n|-\\n! 6\\n| class=\"ItemRight\" | 60: || [[Caretaker's Outfit]] {{Stars|4}}\\n| class=\"ItemRight\" | 63: || [[Medical Experiment]] {{Stars|4}}\\n| class=\"ItemRight\" | 66: || [[Astrometric Chart]] {{Stars|4}}\\n| class=\"ItemRight\" | 70: || [[Medkit]] {{Stars|4}}\\n|-\\n! 7\\n| class=\"ItemRight\" | 70: || [[Caretaker's Outfit]] {{Stars|4}}\\n| class=\"ItemRight\" | 73: || [[Flux Coupler]] {{Stars|5}}\\n| class=\"ItemRight\" | 76: || [[Caretaker's Banjo]] {{Stars|4}}\\n| class=\"ItemRight\" | 80: || [[Submicron Scanner]] {{Stars|4}}\\n|-\\n! 8\\n| class=\"ItemRight\" | 80: || [[Caretaker's Outfit]] {{Stars|5}}\\n| class=\"ItemRight\" | 83: || [[Medical Experiment]] {{Stars|5}}\\n| class=\"ItemRight\" | 86: || [[Astrometric Chart]] {{Stars|4}}\\n| class=\"ItemRight\" | 90: || [[Zero Gravity Training]] {{Stars|4}}\\n|-\\n! 9\\n| class=\"ItemRight\" | 90: || [[Caretaker's Outfit]] {{Stars|5}}\\n| class=\"ItemRight\" | 93: || [[Psychological Evaluation Holoprogram]] {{Stars|4}}\\n| class=\"ItemRight\" | 96: || [[Science Experiment]] {{Stars|5}}\\n| class=\"ItemRight\" | 99: || [[Caretaker's Banjo]] {{Stars|5}}\\n|-\\n|}\\n\\n==Away Team Skills==\\n<onlyinclude>\\n{{Crew Page ATS Table|\\n| CREW_MAX_SKILL={{{1|}}}\\n| CREW_NAME= {{PAGENAME}}\\n| NUM_STARS= 5\\n| SKILL_1= eng\\n| SKILL_2= sci\\n| SKILL_3= med\\n\\n<!------------ Level 1 ------------>\\n| 1STAR_SKILL1_LVL_1= 73\\n| 2STAR_SKILL1_LVL_1= 73\\n| 3STAR_SKILL1_LVL_1= 74\\n| 4STAR_SKILL1_LVL_1= 75\\n| 5STAR_SKILL1_LVL_1= 77\\n| MIN_SKILL1_LVL_1= 22\\n| MAX_SKILL1_LVL_1= 46\\n\\n| 1STAR_SKILL2_LVL_1= 52\\n| 2STAR_SKILL2_LVL_1= 52\\n| 3STAR_SKILL2_LVL_1= 53\\n| 4STAR_SKILL2_LVL_1= 54\\n| 5STAR_SKILL2_LVL_1= 56\\n| MIN_SKILL2_LVL_1= 17\\n| MAX_SKILL2_LVL_1= 34\\n\\n| 1STAR_SKILL3_LVL_1= 31\\n| 2STAR_SKILL3_LVL_1= 31\\n| 3STAR_SKILL3_LVL_1= 32\\n| 4STAR_SKILL3_LVL_1= 33\\n| 5STAR_SKILL3_LVL_1= 33\\n| MIN_SKILL3_LVL_1= 8\\n| MAX_SKILL3_LVL_1= 18\\n\\n<!------------ Level 10 ------------>\\n| 1STAR_SKILL1_LVL_10= 100\\n| 2STAR_SKILL1_LVL_10= 101\\n| 3STAR_SKILL1_LVL_10= 110\\n| 4STAR_SKILL1_LVL_10= 122\\n| 5STAR_SKILL1_LVL_10= 135\\n| MIN_SKILL1_LVL_10= 26\\n| MAX_SKILL1_LVL_10= 56\\n\\n| 1STAR_SKILL2_LVL_10= 71\\n| 2STAR_SKILL2_LVL_10= 75\\n| 3STAR_SKILL2_LVL_10= 84\\n| 4STAR_SKILL2_LVL_10= 98\\n| 5STAR_SKILL2_LVL_10= 114\\n| MIN_SKILL2_LVL_10= 18\\n| MAX_SKILL2_LVL_10= 38\\n\\n| 1STAR_SKILL3_LVL_10= 40\\n| 2STAR_SKILL3_LVL_10= 42\\n| 3STAR_SKILL3_LVL_10= 47\\n| 4STAR_SKILL3_LVL_10= 56\\n| 5STAR_SKILL3_LVL_10= 63\\n| MIN_SKILL3_LVL_10= 9\\n| MAX_SKILL3_LVL_10= 27\\n\\n<!------------ Level 20 ------------>\\n| 1STAR_SKILL1_LVL_20= 131\\n| 2STAR_SKILL1_LVL_20= 134\\n| 3STAR_SKILL1_LVL_20= 151\\n| 4STAR_SKILL1_LVL_20= 176\\n| 5STAR_SKILL1_LVL_20= 201\\n| MIN_SKILL1_LVL_20= 29\\n| MAX_SKILL1_LVL_20= 63\\n\\n| 1STAR_SKILL2_LVL_20= 94\\n| 2STAR_SKILL2_LVL_20= 103\\n| 3STAR_SKILL2_LVL_20= 121\\n| 4STAR_SKILL2_LVL_20= 147\\n| 5STAR_SKILL2_LVL_20= 180\\n| MIN_SKILL2_LVL_20= 21\\n| MAX_SKILL2_LVL_20= 55\\n\\n| 1STAR_SKILL3_LVL_20= 52\\n| 2STAR_SKILL3_LVL_20= 57\\n| 3STAR_SKILL3_LVL_20= 66\\n| 4STAR_SKILL3_LVL_20= 85\\n| 5STAR_SKILL3_LVL_20= 97\\n| MIN_SKILL3_LVL_20= 10\\n| MAX_SKILL3_LVL_20= 30\\n\\n<!------------ Level 30 ------------>\\n| 1STAR_SKILL1_LVL_30= 165\\n| 2STAR_SKILL1_LVL_30= 170\\n| 3STAR_SKILL1_LVL_30= 196\\n| 4STAR_SKILL1_LVL_30= 233\\n| 5STAR_SKILL1_LVL_30= 271\\n| MIN_SKILL1_LVL_30= 41\\n| MAX_SKILL1_LVL_30= 91\\n\\n| 1STAR_SKILL2_LVL_30= 125\\n| 2STAR_SKILL2_LVL_30= 138\\n| 3STAR_SKILL2_LVL_30= 165\\n| 4STAR_SKILL2_LVL_30= 205\\n| 5STAR_SKILL2_LVL_30= 253\\n| MIN_SKILL2_LVL_30= 22\\n| MAX_SKILL2_LVL_30= 60\\n\\n| 1STAR_SKILL3_LVL_30= 62\\n| 2STAR_SKILL3_LVL_30= 69\\n| 3STAR_SKILL3_LVL_30= 83\\n| 4STAR_SKILL3_LVL_30= 112\\n| 5STAR_SKILL3_LVL_30= 130\\n| MIN_SKILL3_LVL_30= 10\\n| MAX_SKILL3_LVL_30= 30\\n\\n<!------------ Level 40 ------------>\\n| 1STAR_SKILL1_LVL_40= 200\\n| 2STAR_SKILL1_LVL_40= 206\\n| 3STAR_SKILL1_LVL_40= 241\\n| 4STAR_SKILL1_LVL_40= 291\\n| 5STAR_SKILL1_LVL_40= 341\\n| MIN_SKILL1_LVL_40= 57\\n| MAX_SKILL1_LVL_40= 145\\n\\n| 1STAR_SKILL2_LVL_40= 153\\n| 2STAR_SKILL2_LVL_40= 170\\n| 3STAR_SKILL2_LVL_40= 207\\n| 4STAR_SKILL2_LVL_40= 259\\n| 5STAR_SKILL2_LVL_40= 324\\n| MIN_SKILL2_LVL_40= 24\\n| MAX_SKILL2_LVL_40= 70\\n\\n| 1STAR_SKILL3_LVL_40= 74\\n| 2STAR_SKILL3_LVL_40= 84\\n| 3STAR_SKILL3_LVL_40= 102\\n| 4STAR_SKILL3_LVL_40= 141\\n| 5STAR_SKILL3_LVL_40= 164\\n| MIN_SKILL3_LVL_40= 11\\n| MAX_SKILL3_LVL_40= 33\\n\\n<!------------ Level 50 ------------>\\n| 1STAR_SKILL1_LVL_50= 268\\n| 2STAR_SKILL1_LVL_50= 276\\n| 3STAR_SKILL1_LVL_50= 319\\n| 4STAR_SKILL1_LVL_50= 381\\n| 5STAR_SKILL1_LVL_50= 444\\n| MIN_SKILL1_LVL_50= 73\\n| MAX_SKILL1_LVL_50= 179\\n\\n| 1STAR_SKILL2_LVL_50= 181\\n| 2STAR_SKILL2_LVL_50= 203\\n| 3STAR_SKILL2_LVL_50= 248\\n| 4STAR_SKILL2_LVL_50= 314\\n| 5STAR_SKILL2_LVL_50= 395\\n| MIN_SKILL2_LVL_50= 28\\n| MAX_SKILL2_LVL_50= 80\\n\\n| 1STAR_SKILL3_LVL_50= 84\\n| 2STAR_SKILL3_LVL_50= 96\\n| 3STAR_SKILL3_LVL_50= 119\\n| 4STAR_SKILL3_LVL_50= 167\\n| 5STAR_SKILL3_LVL_50= 197\\n| MIN_SKILL3_LVL_50= 21\\n| MAX_SKILL3_LVL_50= 73\\n\\n<!------------ Level 60 ------------>\\n| 1STAR_SKILL1_LVL_60= 311\\n| 2STAR_SKILL1_LVL_60= 320\\n| 3STAR_SKILL1_LVL_60= 372\\n| 4STAR_SKILL1_LVL_60= 446\\n| 5STAR_SKILL1_LVL_60= 522\\n| MIN_SKILL1_LVL_60= 99\\n| MAX_SKILL1_LVL_60= 253\\n\\n| 1STAR_SKILL2_LVL_60= 208\\n| 2STAR_SKILL2_LVL_60= 235\\n| 3STAR_SKILL2_LVL_60= 289\\n| 4STAR_SKILL2_LVL_60= 368\\n| 5STAR_SKILL2_LVL_60= 465\\n| MIN_SKILL2_LVL_60= 57\\n| MAX_SKILL2_LVL_60= 165\\n\\n| 1STAR_SKILL3_LVL_60= 104\\n| 2STAR_SKILL3_LVL_60= 118\\n| 3STAR_SKILL3_LVL_60= 145\\n| 4STAR_SKILL3_LVL_60= 203\\n| 5STAR_SKILL3_LVL_60= 239\\n| MIN_SKILL3_LVL_60= 22\\n| MAX_SKILL3_LVL_60= 78\\n\\n<!------------ Level 70 ------------>\\n| 1STAR_SKILL1_LVL_70= 369\\n| 2STAR_SKILL1_LVL_70= 379\\n| 3STAR_SKILL1_LVL_70= 440\\n| 4STAR_SKILL1_LVL_70= 527\\n| 5STAR_SKILL1_LVL_70= 615\\n| MIN_SKILL1_LVL_70= 132\\n| MAX_SKILL1_LVL_70= 320\\n\\n| 1STAR_SKILL2_LVL_70= 276\\n| 2STAR_SKILL2_LVL_70= 307\\n| 3STAR_SKILL2_LVL_70= 370\\n| 4STAR_SKILL2_LVL_70= 463\\n| 5STAR_SKILL2_LVL_70= 576\\n| MIN_SKILL2_LVL_70= 82\\n| MAX_SKILL2_LVL_70= 210\\n\\n| 1STAR_SKILL3_LVL_70= 143\\n| 2STAR_SKILL3_LVL_70= 160\\n| 3STAR_SKILL3_LVL_70= 191\\n| 4STAR_SKILL3_LVL_70= 259\\n| 5STAR_SKILL3_LVL_70= 301\\n| MIN_SKILL3_LVL_70= 62\\n| MAX_SKILL3_LVL_70= 178\\n\\n<!------------ Level 80 ------------>\\n| 1STAR_SKILL1_LVL_80= 426\\n| 2STAR_SKILL1_LVL_80= 438\\n| 3STAR_SKILL1_LVL_80= 508\\n| 4STAR_SKILL1_LVL_80= 607\\n| 5STAR_SKILL1_LVL_80= 708\\n| MIN_SKILL1_LVL_80= 205\\n| MAX_SKILL1_LVL_80= 547\\n\\n| 1STAR_SKILL2_LVL_80= 314\\n| 2STAR_SKILL2_LVL_80= 349\\n| 3STAR_SKILL2_LVL_80= 421\\n| 4STAR_SKILL2_LVL_80= 527\\n| 5STAR_SKILL2_LVL_80= 657\\n| MIN_SKILL2_LVL_80= 92\\n| MAX_SKILL2_LVL_80= 230\\n\\n| 1STAR_SKILL3_LVL_80= 173\\n| 2STAR_SKILL3_LVL_80= 192\\n| 3STAR_SKILL3_LVL_80= 228\\n| 4STAR_SKILL3_LVL_80= 306\\n| 5STAR_SKILL3_LVL_80= 353\\n| MIN_SKILL3_LVL_80= 67\\n| MAX_SKILL3_LVL_80= 193\\n\\n<!------------ Level 90 ------------>\\n| 1STAR_SKILL1_LVL_90= 519\\n| 2STAR_SKILL1_LVL_90= 533\\n| 3STAR_SKILL1_LVL_90= 611\\n| 4STAR_SKILL1_LVL_90= 723\\n| 5STAR_SKILL1_LVL_90= 836\\n| MIN_SKILL1_LVL_90= 270\\n| MAX_SKILL1_LVL_90= 682\\n\\n| 1STAR_SKILL2_LVL_90= 397\\n| 2STAR_SKILL2_LVL_90= 437\\n| 3STAR_SKILL2_LVL_90= 518\\n| 4STAR_SKILL2_LVL_90= 637\\n| 5STAR_SKILL2_LVL_90= 782\\n| MIN_SKILL2_LVL_90= 127\\n| MAX_SKILL2_LVL_90= 295\\n\\n| 1STAR_SKILL3_LVL_90= 182\\n| 2STAR_SKILL3_LVL_90= 204\\n| 3STAR_SKILL3_LVL_90= 244\\n| 4STAR_SKILL3_LVL_90= 332\\n| 5STAR_SKILL3_LVL_90= 385\\n| MIN_SKILL3_LVL_90= 107\\n| MAX_SKILL3_LVL_90= 353\\n\\n<!------------ Level 100 ------------>\\n| 1STAR_SKILL1_LVL_100= 612\\n| 2STAR_SKILL1_LVL_100= 627\\n| 3STAR_SKILL1_LVL_100= 714\\n| 4STAR_SKILL1_LVL_100= 838\\n| 5STAR_SKILL1_LVL_100= 964\\n| MIN_SKILL1_LVL_100= 335\\n| MAX_SKILL1_LVL_100= 817\\n\\n| 1STAR_SKILL2_LVL_100= 450\\n| 2STAR_SKILL2_LVL_100= 494\\n| 3STAR_SKILL2_LVL_100= 584\\n| 4STAR_SKILL2_LVL_100= 716\\n| 5STAR_SKILL2_LVL_100= 878\\n| MIN_SKILL2_LVL_100= 187\\n| MAX_SKILL2_LVL_100= 495\\n\\n| 1STAR_SKILL3_LVL_100= 227\\n| 2STAR_SKILL3_LVL_100= 251\\n| 3STAR_SKILL3_LVL_100= 296\\n| 4STAR_SKILL3_LVL_100= 393\\n| 5STAR_SKILL3_LVL_100= 452\\n| MIN_SKILL3_LVL_100= 122\\n| MAX_SKILL3_LVL_100= 378\\n}}\\n</onlyinclude>\\n\\n== Ship Ability and Bonuses ==\\n{|\\n|-\\n|\\n{| class=\"wikitable\" style=\"text-align:center; font-size:90%;\"\\n! colspan=\"5\" | {{PAGENAME}}'s<br>Passive Ship Stat Bonuses\\n|-\\n| colspan=\"5\" | Only active in {{skill|eng}}, {{skill|sci}}, or {{skill|med}} [[battle stations]]\\n|-\\n! Level\\n| {{skill|passiveacc|}} || {{skill|passivecbonus|}} || {{skill|passivecrating|}} || {{skill|passiveeva|}}\\n|- <!-- Special Character: emdash for 0: \" — \" -->\\n| 1 || — || — || — || —\\n|-\\n| 10 || — || — || — || —\\n|-\\n| 20 || — || — || — || 15\\n|-\\n| 30 || 25 || — || 3 || 15\\n|-\\n| 40 || 25 || — || 3 || 30\\n|-\\n| 50 || 25 || — || 3 || 180\\n|-\\n| 60 || 25 || — || 3 || 205\\n|-\\n| 70 || 25 || — || 3 || 205\\n|-\\n| 80 || 25 || 200 || 3 || 255\\n|-\\n| 90 || 225 || 200 || 73 || 355\\n|-\\n| 100 || 425 || 200 || 113 || 455\\n|}\\n|<onlyinclude>\\n{{ShipAbility\\n| CREW_MAX_SKILL={{{1|}}}\\n| Crew={{PAGENAME}}\\n| Stars   = 5\\n| Ability = eva\\n| 1StarAbilityBoost= 3\\n| BattleQuote = A Debt of Honor\\n| Initialize= 6\\n| Cooldown  = 14\\n| Duration  = 8\\n| BonusAbilitySkillIcon= shield\\n| BonusAbilityText     = +2000 to Shield Regeneration\\n| Trigger          = \\n| ChargePhases1Text= After &nbsp;&nbsp;8s, +2500 to Shield Regeneration\\n| ChargePhases2Text= After 18s, +3000 to Shield Regeneration\\n| HandicapText     = \\n| UsesPerBattle    = \\n}}\\n</onlyinclude>\\n|}\\n\\n==Notes==\\n* {{PAGENAME}} was added February 27, 2018 as the new rare reward in [[The Gauntlet|the Gauntlet]], replacing [[Bartender Guinan]].\\n** He was eventually replaced in the Gauntlet by [[Armus]].\\n\\n==Quotes==\\n*\"quote1\"\\n*\"quote2\"\\n\\n==See Also==\\n{{SACharacter|Caretaker}}\\n\\n{{CrewNav}}\\n\\n[[Category:Star Trek: Voyager]]\\n[[Category:Gauntlet Exclusives]]";
			//WikiData wikiData = new WikiData(wikiText);
			//SkillsRow level = wikiData.parseWikiText();
			//LevelTable levelTable = new LevelTable();
			//levelTable.Levels = new SkillsRow[1];
			//levelTable.WikiName = "The_Caretaker";
			//levelTable.Levels[0] = level;

			//string wikiName = "Disguised_Kira";
			//WikiData wikiData = new WikiData();
			//SkillsRow level2 = wikiData.parseWikiTextFromPageName(wikiName);
			//level2 = AddBuffs(level2, buffs);
			//LevelTable levelTable2 = new LevelTable();
			//levelTable2.Levels = new SkillsRow[1];
			//levelTable2.WikiName = wikiName;
			//levelTable2.Levels[0] = level2;
			//levelTables.Add(levelTable2);

			//List<LevelTable> levelTablesTemp = new List<LevelTable>();
			//levelTablesTemp.Add(levelTable);
			//levelTablesTemp.Add(levelTable2);

			//var oneStar = levelTable2.Levels[0].CoreSkills[0];
			//var twoStar = levelTable2.Levels[0].CoreSkills[1];
			//foreach(KeyValuePair<string, int> skill in oneStar) {
			//	int oneStarValue = skill.Value;
			//	int twoStarValue = twoStar.Where(ts => ts.Key == skill.Key).FirstOrDefault().Value;
			//}

			//string levelTablesJson = JsonConvert.SerializeObject(levelTables);
			//File.WriteAllText(@"C:\Users\nikea\Desktop\STT\LevelTables.json", levelTablesJson);

			//int x = 0;

			/*
			 */

			//var x = dataCoreCrew.Where(dcc => dcc.Name == "Age of Sail Data");

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
			string primarySkill = "ScienceSkill";
			string secondarySkill = "MedicineSkill";
			string voyageSlotSkill = "MedicineSkill";
			string trait = "doctor";
			sttUser.Player.Character.Crew
			.Where(c => c.VoyageScoreForSkillPair(primarySkill, secondarySkill, false) > 0 && c.VoyageScores[voyageSlotSkill] > 0 && c.Traits.Contains(trait))
			.OrderByDescending(c => c.VoyageScoreForSkillPair(primarySkill, secondarySkill, false))
			.Take(10)
			.ForEach(c => Console.WriteLine(c.Name + " (" + c.Rarity + "/" + c.MaxRarity + ") - " + c.VoyageScoreForSkillPair(primarySkill, secondarySkill, false)));
			// ***End Voyagers with a specific trait and 2000+ in two skills ***

			// *** Top ten voyagers by skill pair ***
			//string primarySkill = "EngineeringSkill";
			//string secondarySkill = "DiplomacySkill";
			//sttUser.Player.Character.Crew.OrderByDescending(c => c.VoyageScoreForSkillPair(primarySkill, secondarySkill)).Take(10).ForEach(c => Console.WriteLine(c.Name + " (" + c.Rarity + "/" + c.MaxRarity + ") - " + c.VoyageScoreForSkillPair(primarySkill, secondarySkill)));
			//Console.WriteLine();
			//sttUser.Player.Character.Crew.OrderByDescending(c => c.VoyageScoreForSkillPair(primarySkill, secondarySkill, true)).Take(10).ForEach(c => Console.WriteLine(c.Name + " (" + c.Rarity + "/" + c.MaxRarity + ") - " + c.VoyageScoreForSkillPair(primarySkill, secondarySkill, true)));
			// *** End Top ten voyagers by skill pair ***

			// *** Order golds by tier ***
			//dataCoreCrew.Where(c => c.MaxRarity == 5 && c.Have == true && c.Rarity != c.MaxRarity && c.Level != 100).OrderBy(c => c.Tier).ForEach(c => Console.WriteLine(c.Name + " - T" + c.Tier.ToString() + ", " + c.Rarity));
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

		private static T GetStaticData<T>(string fileName)
		{
			using (WebClient client = new WebClient())
			{
				string s = client.DownloadString("https://raw.githubusercontent.com/stt-datacore/website/master/static/structured/" + fileName);
				return JsonConvert.DeserializeObject<T>(s);
			}
		}

		private static SkillsRow AddBuffs(SkillsRow level2, Dictionary<string, (double, double, double)> buffs)
		{
			foreach (KeyValuePair<string, (double CoreBuff, double MinBuff, double MaxBuff)> buff in buffs)
			{
				for (int stars = 0; stars < level2.CoreSkills.Length; stars++)
				{
					if (level2.CoreSkills[stars].ContainsKey(buff.Key))
					{
						double buffedValue = level2.CoreSkills[stars][buff.Key] * (1 + buff.Value.CoreBuff);
						level2.CoreSkills[stars][buff.Key] = (int)(buffedValue + .5);
					}
				}
				if (level2.MinProficiency.ContainsKey(buff.Key))
				{
					double buffedValue = level2.MinProficiency[buff.Key] * (1 + buff.Value.MinBuff);
					level2.MinProficiency[buff.Key] = (int)(buffedValue + .5);
				}
				if (level2.MaxProficiency.ContainsKey(buff.Key))
				{
					double buffedValue = level2.MaxProficiency[buff.Key] * (1 + buff.Value.MaxBuff);
					level2.MaxProficiency[buff.Key] = (int)(buffedValue + .5);
				}
			}

			return level2;
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
					for (int i = 3; i < 26 * 13 + 9 + 1; i++)
					{
						if (tempLine[i] != "0")
						{
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

					result.Add(crew);
				}
			}

			return result;
		}
	}
}
