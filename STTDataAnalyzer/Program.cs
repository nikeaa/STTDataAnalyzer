using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using STTDataAnalyzer.Models.Wiki;
using System.IO;
using System.Configuration;
using STTDataAnalyzer.Models.PlayerData;
using System.Linq;
using NewUtilities;

namespace STTDataAnalyzer
{
    public class Program
    {
        // CMD = DIP - SEC - ENG - SCI - MED
        public static Dictionary<string, int> voyageTraitsSkills = new Dictionary<string, int>()
        {
            { "astrophysicist",         0b110110 },
            { "bajoran",                0b111000 },
            { "borg",                   0b001110 },
            { "brutal",                 0b111110 },
            { "cardassian",             0b111000 },
            { "civilian",               0b111111 },
            { "communicator",           0b111000 },
            { "costumed",               0b111110 },
            { "crafty",                 0b111010 },
            { "cultural_figure",        0b111000 },
            { "cyberneticist",          0b000110 },
            { "desperate",              0b111110 },
            { "diplomat",               0b111000 },
            { "duelist",                0b111000 },
            { "exobiology",             0b000010 },
            { "explorer",               0b100000 },
            { "federation",             0b111111 },
            { "ferengi",                0b010000 },
            { "gambler",                0b111000 },
            { "hero",                   0b111000 },
            { "hologram",               0b110011 },
            { "human",                  0b111111 },
            { "hunter",                 0b101000 },
            { "innovator",              0b100110 },
            { "inspiring",              0b111000 },
            { "jury_rigger",            0b101100 },
            { "klingon",                0b111000 },
            { "marksman",               0b001000 },
            { "maverick",               0b111000 },
            { "physician",              0b010011 },
            { "pilot",                  0b101100 },
            { "prodigy",                0b000110 },
            { "resourceful",            0b111110 },
            { "romantic",               0b111110 },
            { "romulan",                0b011000 },
            { "saboteur",               0b101000 },
            { "starfleet",              0b111111 },
            { "survivalist",            0b111000 },
            { "tactician",              0b111110 },
            { "telepath",               0b111010 },
            { "undercover_operative",   0b111010 },
            { "veteran",                0b111000 },
            { "villain",                0b111000 },
            { "vulcan",                 0b111010 }
        };

        [Flags]
        public enum SkillsEnum
        {
            None = 0,
            Medicine = 1,
            Science = 2,
            Engineering = 4,
            Security = 8,
            Diplomacy = 16,
            Command = 32
        }

        [STAThread]
        private static void Main(string[] args)
        {
            //string data = GetPlayerData.Retrieve();

            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.MissingMemberHandling = MissingMemberHandling.Error;

            //string jsonString = PlayerData.RetrieveFromDB();
            //File.WriteAllText(FileNameAndPath, jsonString);

            string jsonString = PlayerData.ReadFromFile();

            var playerData = PlayerData.FromJson(jsonString);

            //int am = 2875;
            //Skill primary = new Skill() { Core = 9877, RangeMin = 1470, RangeMax = 3398 };
            //Skill secondary = new Skill() { Core = 8946, RangeMin = 1582, RangeMax = 3855 };
            //Skill tertiary1 = new Skill() { Core = 6675, RangeMin = 1168, RangeMax = 2354 };
            //Skill tertiary2 = new Skill() { Core = 4464, RangeMin = 751, RangeMax = 1626};
            //Skill tertiary3 = new Skill() { Core = 4078, RangeMin = 565, RangeMax = 1289 };
            //Skill tertiary4 = new Skill() { Core = 3175, RangeMin = 435, RangeMax = 875 };
            //int voyageEstimate = PlayerData.GetVoyageTimeEstimate(primary, secondary, tertiary1, tertiary2, tertiary3, tertiary4, am, 1000);
            //Console.WriteLine(voyageEstimate);


            //List<Crew> crew = playerData.Player.Character.Crew;

            //SkillsEnum se = new SkillsEnum();

            //var values = Enum.GetValues(typeof(SkillsEnum)).Cast<SkillsEnum>();
            //foreach (var value in values)
            //{
            //    Console.WriteLine(value);
            //}


            // CMD - DIP - SEC - ENG - SCI - MED
            //foreach (var item in voyageTraitsSkills)
            //{
            //    Console.WriteLine(item.Key + " - " + item.Value);
            //var values = Enum.GetValues(typeof(SkillsEnum)).Cast<SkillsEnum>();
            //foreach (var value in values)
            //{
            //    int flag = (int)value;
            //    if ((flag & item.Value) > 0)
            //    {
            //        Console.Write(value.ToString() + " ");
            //    }
            //}
            //Console.WriteLine("");
            //}

            //PlayerData pd = JsonConvert.DeserializeObject<PlayerData>(jsonString, settings);

            //x.ForEach(c => Console.WriteLine(c.Name + " - "+ c.DiplomacyVoyageScore + " " + c.EngineeringVoyageScore + " " + (c.CommandVoyageScore + c.MedicineVoyageScore + c.ScienceVoyageScore + c.SecurityVoyageScore)));
            //PlayerData playerData = new PlayerData();
            //DataCore dataCore = new DataCore();
            //StaticData staticData = new StaticData();
            //List<LevelTable> levelTables = new List<LevelTable>();
            //List<PdCrew> x = playerData.Player.Character.Crew.OrderByDescending(c => c.CommandVoyageScore * .35 + c.DiplomacyVoyageScore * .25 + c.EngineeringVoyageScore * .1 + c.MedicineVoyageScore * .1 + c.ScienceVoyageScore * .1 + c.SecurityVoyageScore * .1).ToList();
            //x.ForEach(c => Console.WriteLine(c.Name + " - " + (c.CommandVoyageScore * .35 + c.DiplomacyVoyageScore * .25 + c.EngineeringVoyageScore * .1 + c.MedicineVoyageScore * .1 + c.ScienceVoyageScore * .1 + c.SecurityVoyageScore * .1)));


            // Select all crew with a specific trait and skill
            //List<PdCrew> x = playerData.Player.Character.Crew.Where(c => c.Traits.Contains("gambler") && c.Skills.CommandSkill!= null).OrderByDescending(c => c.DiplomacyVoyageScore + c.EngineeringVoyageScore).ToList();
            //x.ForEach(c => Console.WriteLine(c.Name + " - "+ c.DiplomacyVoyageScore + " " + c.EngineeringVoyageScore + " " + (c.CommandVoyageScore + c.MedicineVoyageScore + c.ScienceVoyageScore + c.SecurityVoyageScore)));

            // Select crew by trait by voyage score
            //List<PdCrew> y = playerData.Player.Character.Crew.Where(c => c.Traits.Contains("vulcan") && c.Skills.ScienceSkill != null && c.Skills.CommandSkill == null && c.Skills.DiplomacySkill == null).OrderByDescending(c => c.VoyageScores.Sum(v => v.Value)).ToList();
            //y.ForEach(c => Console.WriteLine(c.Name + " - " + c.VoyageScores.Sum(v => v.Value)));

            //VoyageDescription vd = playerData.Player.Character.VoyageDescriptions.First();
            //vd.CrewSlots
            //.ForEach(cs => {
            //	Console.WriteLine("=============================================================================");
            //	Console.WriteLine(string.Format("Name: {0} - Skill: {1}, Trait: {2}", cs.Name, cs.Skill, cs.Trait));

            //	// Has trait and skill for the slot and both primary and secondary skill
            //	playerData.Player.Character.Crew
            //		.Where(c => c.Traits.Contains(cs.Trait) && c.HasSkillForVoyageSlot(cs) && (c.HasPrimarySkillForVoyage(vd) && c.HasSecondarySkillForVoyage(vd)))
            //		.OrderByDescending(c => c.PrimarySkillForVoyageValue(vd) + c.SecondarySkillForVoyageValue(vd) + c.TertiarySkillForVoyageValue(vd))
            //		.ForEach(c => Console.WriteLine(string.Format("   {0} - {1}/{2}/{3}", c.Name, c.PrimarySkillForVoyageValue(vd), c.SecondarySkillForVoyageValue(vd), c.TertiarySkillForVoyageValue(vd))));

            //	Console.WriteLine("-----------------------------------------------------------------------------");

            //	// Has trait and voyage value 4000+
            //	playerData.Player.Character.Crew
            //		.Where(c => c.Traits.Contains(cs.Trait) && c.HasSkillForVoyageSlot(cs) && (c.PrimarySkillForVoyageValue(vd) + c.SecondarySkillForVoyageValue(vd) + c.TertiarySkillForVoyageValue(vd) >= 4000))
            //		.OrderByDescending(c => c.PrimarySkillForVoyageValue(vd) + c.SecondarySkillForVoyageValue(vd) + c.TertiarySkillForVoyageValue(vd))
            //		.ForEach(c => Console.WriteLine(string.Format("   {0} - {1}/{2}/{3}", c.Name, c.PrimarySkillForVoyageValue(vd), c.SecondarySkillForVoyageValue(vd),c.TertiarySkillForVoyageValue(vd))));

            //	Console.WriteLine("****************************************************************************");

            //	// Has trait and 3500 <= voyage value < 4000
            //	playerData.Player.Character.Crew
            //		.Where(c => c.Traits.Contains(cs.Trait) && c.HasSkillForVoyageSlot(cs) && (3500 <= c.PrimarySkillForVoyageValue(vd) + c.SecondarySkillForVoyageValue(vd) + c.TertiarySkillForVoyageValue(vd) && c.PrimarySkillForVoyageValue(vd) + c.SecondarySkillForVoyageValue(vd) + c.TertiarySkillForVoyageValue(vd) < 4000))
            //		.OrderByDescending(c => c.PrimarySkillForVoyageValue(vd) + c.SecondarySkillForVoyageValue(vd) + c.TertiarySkillForVoyageValue(vd))
            //		.ForEach(c => Console.WriteLine(string.Format("   {0} - {1}/{2}/{3}", c.Name, c.PrimarySkillForVoyageValue(vd), c.SecondarySkillForVoyageValue(vd), c.TertiarySkillForVoyageValue(vd))));

            //	Console.WriteLine("-----------------------------------------------------------------------------");

            //	// Does not have trait but voyage value 4000+
            //	playerData.Player.Character.Crew
            //		.Where(c => !c.Traits.Contains(cs.Trait) && c.HasSkillForVoyageSlot(cs) && (c.PrimarySkillForVoyageValue(vd) + c.SecondarySkillForVoyageValue(vd) + c.TertiarySkillForVoyageValue(vd) >= 4000))
            //		.OrderByDescending(c => c.PrimarySkillForVoyageValue(vd) + c.SecondarySkillForVoyageValue(vd) + c.TertiarySkillForVoyageValue(vd))
            //		.ForEach(c => Console.WriteLine(string.Format("   {0} - {1}/{2}/{3}", c.Name, c.PrimarySkillForVoyageValue(vd), c.SecondarySkillForVoyageValue(vd), c.TertiarySkillForVoyageValue(vd))));

            //	Console.WriteLine("****************************************************************************");

            //	// Does not have trait but voyage value 4000+
            //	playerData.Player.Character.Crew
            //		.Where(c => !c.Traits.Contains(cs.Trait) && c.HasSkillForVoyageSlot(cs) && (3500 <= c.PrimarySkillForVoyageValue(vd) + c.SecondarySkillForVoyageValue(vd) + c.TertiarySkillForVoyageValue(vd) && c.PrimarySkillForVoyageValue(vd) + c.SecondarySkillForVoyageValue(vd) + c.TertiarySkillForVoyageValue(vd) < 4000))
            //		.OrderByDescending(c => c.PrimarySkillForVoyageValue(vd) + c.SecondarySkillForVoyageValue(vd) + c.TertiarySkillForVoyageValue(vd))
            //		.ForEach(c => Console.WriteLine(string.Format("   {0} - {1}/{2}/{3}", c.Name, c.PrimarySkillForVoyageValue(vd), c.SecondarySkillForVoyageValue(vd), c.TertiarySkillForVoyageValue(vd))));
            //});

            //playerData.Player.Character.Crew

            //.Where(c => c.Traits.Contains("starfleet") && c.Skills.DiplomacySkill != null && (c.Skills.ScienceSkill != null && c.Skills.CommandSkill != null))
            //.OrderByDescending(c => c.CommandVoyageScore)
            //.ForEach(c => Console.WriteLine(c.Name + "- SCI:" + c.ScienceVoyageScore + ", CMD:" + c.CommandVoyageScore + ", DIP:" + c.DiplomacyVoyageScore + ", ENG:" + c.EngineeringVoyageScore + ", MED:" + c.MedicineVoyageScore + ", SEC:" + c.SecurityVoyageScore));

            //.Where(c => c.Traits.Contains("jury_rigger") && c.Skills.EngineeringSkill != null)
            //.OrderByDescending(c => c.ScienceVoyageScore)
            //.ForEach(c => Console.WriteLine(c.Name + "- SCI:" + c.ScienceVoyageScore + ", CMD:" + c.CommandVoyageScore + ", DIP:" + c.DiplomacyVoyageScore + ", ENG:" + c.EngineeringVoyageScore + ", MED:" + c.MedicineVoyageScore + ", SEC:" + c.SecurityVoyageScore));

            //.Where(c => c.Skills.DiplomacySkill != null && c.Skills.CommandSkill != null)
            //.OrderByDescending(c => c.CommandVoyageScore)
            //.ForEach(c => Console.WriteLine(c.Name + "- SCI:" + c.ScienceVoyageScore + ", CMD:" + c.CommandVoyageScore + ", DIP:" + c.DiplomacyVoyageScore + ", ENG:" + c.EngineeringVoyageScore + ", MED:" + c.MedicineVoyageScore + ", SEC:" + c.SecurityVoyageScore));


            // TODO: Create 'Buffs' object and use instead of dictionary 
            //Dictionary<string, (double, double, double)> buffs = playerData.Player.Character.GetBuffs();

            // *** Get Level 100 skills at all star levels from wiki data ***
            //string wikiText = "<!-- Created from Template:Crew/add -->{{Infobox crew\\n |stars = 5\\n |CMD =  | DIP =  | ENG = 73 | SEC =  | SCI = 52 | MED = 31\\n <!--traits:-->| Caregiver| Desperate| Explorer| Musician| Nacene| Cultural Figure| Theoretical Engineer\\n |abil = eva\\n |char = Caretaker\\n |Row 6 title\t= Other Versions\\n |Row 6 info\t= [[Caretaker#Versions | Caretaker Versions]]\\n}} \\n\\n'''{{PAGENAME}}''' is a [[Legendary]] [5-star] [[crew]] member. \\n\\n{{PAGENAME}} is a version of the [[Caretaker]] from the [[VOY|''Star Trek: Voyager'']] episode [http://memory-alpha.wikia.com/wiki/Caretaker_%28episode%29 \"Caretaker\" (1x01)].\\n\\n{{CrewTOC|{{PAGENAME}}}}\\n\\n<div class=\"mobileclear\"></div><!-- Do not change to clear:both, this will shift page down if screen too narrow for tables as needed -->\\n\\n==Advancement==\\nThese [[items]] are required by {{PAGENAME}} in order to advance through groups of levels.\\n{| class=\"wikitable\"\\n|-\\n! style=\"font-size:75%;\" | Equip<br>Rank !! colspan=\"2\" | Equipment 1 !! colspan=\"2\" | Equipment 2 !! colspan=\"2\" | Equipment  3 !! colspan=\"2\" | Equipment 4\\n|-\\n! 0\\n| class=\"ItemRight\" | 1: || [[Caretaker's Outfit]]\\n| class=\"ItemRight\" | 2: || [[Biological Sample Kit]]\\n| class=\"ItemRight\" | 4: || [[Medical Experiment]] {{Stars|1}}\\n| class=\"ItemRight\" | 5: || [[Quantum Flux Regulator]] {{Stars|1}}\\n|-\\n! 1\\n| class=\"ItemRight\" | 10: || [[Caretaker's Outfit]] {{Stars|1}}\\n| class=\"ItemRight\" | 13: || [[Science Experiment]] {{Stars|1}}\\n| class=\"ItemRight\" | 16: || [[Astrometric Chart]] {{Stars|1}}\\n| class=\"ItemRight\" | 20: || [[Caretaker's Banjo]] {{Stars|2}}\\n|-\\n! 2\\n| class=\"ItemRight\" | 20: || [[Caretaker's Outfit]] {{Stars|2}}\\n| class=\"ItemRight\" | 23: || [[Psychological Evaluation Holoprogram]] {{Stars|1}}\\n| class=\"ItemRight\" | 26: || [[Quantum Flux Regulator]] {{Stars|2}}\\n| class=\"ItemRight\" | 30: || [[Biological Sample Kit]] {{Stars|2}}\\n|-\\n! 3\\n| class=\"ItemRight\" | 30: || [[Caretaker's Outfit]] {{Stars|2}}\\n| class=\"ItemRight\" | 33: || [[Astrometric Chart]] {{Stars|2}}\\n| class=\"ItemRight\" | 36: || [[Flux Coupler]] {{Stars|3}}\\n| class=\"ItemRight\" | 40: || [[Caretaker's Banjo]] {{Stars|2}}\\n|-\\n! 4\\n| class=\"ItemRight\" | 40: || [[Caretaker's Outfit]] {{Stars|3}}\\n| class=\"ItemRight\" | 43: || [[Medical Experiment]] {{Stars|3}}\\n| class=\"ItemRight\" | 46: || [[Engineering Lesson]] {{Stars|3}}\\n| class=\"ItemRight\" | 50: || [[Encoded Communique]] {{Stars|3}}\\n|-\\n! 5\\n| class=\"ItemRight\" | 50: || [[Caretaker's Outfit]] {{Stars|3}}\\n| class=\"ItemRight\" | 53: || [[Science Experiment]] {{Stars|4}}\\n| class=\"ItemRight\" | 56: || [[Flux Coupler]] {{Stars|3}}\\n| class=\"ItemRight\" | 60: || [[Caretaker's Banjo]] {{Stars|3}}\\n|-\\n! 6\\n| class=\"ItemRight\" | 60: || [[Caretaker's Outfit]] {{Stars|4}}\\n| class=\"ItemRight\" | 63: || [[Medical Experiment]] {{Stars|4}}\\n| class=\"ItemRight\" | 66: || [[Astrometric Chart]] {{Stars|4}}\\n| class=\"ItemRight\" | 70: || [[Medkit]] {{Stars|4}}\\n|-\\n! 7\\n| class=\"ItemRight\" | 70: || [[Caretaker's Outfit]] {{Stars|4}}\\n| class=\"ItemRight\" | 73: || [[Flux Coupler]] {{Stars|5}}\\n| class=\"ItemRight\" | 76: || [[Caretaker's Banjo]] {{Stars|4}}\\n| class=\"ItemRight\" | 80: || [[Submicron Scanner]] {{Stars|4}}\\n|-\\n! 8\\n| class=\"ItemRight\" | 80: || [[Caretaker's Outfit]] {{Stars|5}}\\n| class=\"ItemRight\" | 83: || [[Medical Experiment]] {{Stars|5}}\\n| class=\"ItemRight\" | 86: || [[Astrometric Chart]] {{Stars|4}}\\n| class=\"ItemRight\" | 90: || [[Zero Gravity Training]] {{Stars|4}}\\n|-\\n! 9\\n| class=\"ItemRight\" | 90: || [[Caretaker's Outfit]] {{Stars|5}}\\n| class=\"ItemRight\" | 93: || [[Psychological Evaluation Holoprogram]] {{Stars|4}}\\n| class=\"ItemRight\" | 96: || [[Science Experiment]] {{Stars|5}}\\n| class=\"ItemRight\" | 99: || [[Caretaker's Banjo]] {{Stars|5}}\\n|-\\n|}\\n\\n==Away Team Skills==\\n<onlyinclude>\\n{{Crew Page ATS Table|\\n| CREW_MAX_SKILL={{{1|}}}\\n| CREW_NAME= {{PAGENAME}}\\n| NUM_STARS= 5\\n| SKILL_1= eng\\n| SKILL_2= sci\\n| SKILL_3= med\\n\\n<!------------ Level 1 ------------>\\n| 1STAR_SKILL1_LVL_1= 73\\n| 2STAR_SKILL1_LVL_1= 73\\n| 3STAR_SKILL1_LVL_1= 74\\n| 4STAR_SKILL1_LVL_1= 75\\n| 5STAR_SKILL1_LVL_1= 77\\n| MIN_SKILL1_LVL_1= 22\\n| MAX_SKILL1_LVL_1= 46\\n\\n| 1STAR_SKILL2_LVL_1= 52\\n| 2STAR_SKILL2_LVL_1= 52\\n| 3STAR_SKILL2_LVL_1= 53\\n| 4STAR_SKILL2_LVL_1= 54\\n| 5STAR_SKILL2_LVL_1= 56\\n| MIN_SKILL2_LVL_1= 17\\n| MAX_SKILL2_LVL_1= 34\\n\\n| 1STAR_SKILL3_LVL_1= 31\\n| 2STAR_SKILL3_LVL_1= 31\\n| 3STAR_SKILL3_LVL_1= 32\\n| 4STAR_SKILL3_LVL_1= 33\\n| 5STAR_SKILL3_LVL_1= 33\\n| MIN_SKILL3_LVL_1= 8\\n| MAX_SKILL3_LVL_1= 18\\n\\n<!------------ Level 10 ------------>\\n| 1STAR_SKILL1_LVL_10= 100\\n| 2STAR_SKILL1_LVL_10= 101\\n| 3STAR_SKILL1_LVL_10= 110\\n| 4STAR_SKILL1_LVL_10= 122\\n| 5STAR_SKILL1_LVL_10= 135\\n| MIN_SKILL1_LVL_10= 26\\n| MAX_SKILL1_LVL_10= 56\\n\\n| 1STAR_SKILL2_LVL_10= 71\\n| 2STAR_SKILL2_LVL_10= 75\\n| 3STAR_SKILL2_LVL_10= 84\\n| 4STAR_SKILL2_LVL_10= 98\\n| 5STAR_SKILL2_LVL_10= 114\\n| MIN_SKILL2_LVL_10= 18\\n| MAX_SKILL2_LVL_10= 38\\n\\n| 1STAR_SKILL3_LVL_10= 40\\n| 2STAR_SKILL3_LVL_10= 42\\n| 3STAR_SKILL3_LVL_10= 47\\n| 4STAR_SKILL3_LVL_10= 56\\n| 5STAR_SKILL3_LVL_10= 63\\n| MIN_SKILL3_LVL_10= 9\\n| MAX_SKILL3_LVL_10= 27\\n\\n<!------------ Level 20 ------------>\\n| 1STAR_SKILL1_LVL_20= 131\\n| 2STAR_SKILL1_LVL_20= 134\\n| 3STAR_SKILL1_LVL_20= 151\\n| 4STAR_SKILL1_LVL_20= 176\\n| 5STAR_SKILL1_LVL_20= 201\\n| MIN_SKILL1_LVL_20= 29\\n| MAX_SKILL1_LVL_20= 63\\n\\n| 1STAR_SKILL2_LVL_20= 94\\n| 2STAR_SKILL2_LVL_20= 103\\n| 3STAR_SKILL2_LVL_20= 121\\n| 4STAR_SKILL2_LVL_20= 147\\n| 5STAR_SKILL2_LVL_20= 180\\n| MIN_SKILL2_LVL_20= 21\\n| MAX_SKILL2_LVL_20= 55\\n\\n| 1STAR_SKILL3_LVL_20= 52\\n| 2STAR_SKILL3_LVL_20= 57\\n| 3STAR_SKILL3_LVL_20= 66\\n| 4STAR_SKILL3_LVL_20= 85\\n| 5STAR_SKILL3_LVL_20= 97\\n| MIN_SKILL3_LVL_20= 10\\n| MAX_SKILL3_LVL_20= 30\\n\\n<!------------ Level 30 ------------>\\n| 1STAR_SKILL1_LVL_30= 165\\n| 2STAR_SKILL1_LVL_30= 170\\n| 3STAR_SKILL1_LVL_30= 196\\n| 4STAR_SKILL1_LVL_30= 233\\n| 5STAR_SKILL1_LVL_30= 271\\n| MIN_SKILL1_LVL_30= 41\\n| MAX_SKILL1_LVL_30= 91\\n\\n| 1STAR_SKILL2_LVL_30= 125\\n| 2STAR_SKILL2_LVL_30= 138\\n| 3STAR_SKILL2_LVL_30= 165\\n| 4STAR_SKILL2_LVL_30= 205\\n| 5STAR_SKILL2_LVL_30= 253\\n| MIN_SKILL2_LVL_30= 22\\n| MAX_SKILL2_LVL_30= 60\\n\\n| 1STAR_SKILL3_LVL_30= 62\\n| 2STAR_SKILL3_LVL_30= 69\\n| 3STAR_SKILL3_LVL_30= 83\\n| 4STAR_SKILL3_LVL_30= 112\\n| 5STAR_SKILL3_LVL_30= 130\\n| MIN_SKILL3_LVL_30= 10\\n| MAX_SKILL3_LVL_30= 30\\n\\n<!------------ Level 40 ------------>\\n| 1STAR_SKILL1_LVL_40= 200\\n| 2STAR_SKILL1_LVL_40= 206\\n| 3STAR_SKILL1_LVL_40= 241\\n| 4STAR_SKILL1_LVL_40= 291\\n| 5STAR_SKILL1_LVL_40= 341\\n| MIN_SKILL1_LVL_40= 57\\n| MAX_SKILL1_LVL_40= 145\\n\\n| 1STAR_SKILL2_LVL_40= 153\\n| 2STAR_SKILL2_LVL_40= 170\\n| 3STAR_SKILL2_LVL_40= 207\\n| 4STAR_SKILL2_LVL_40= 259\\n| 5STAR_SKILL2_LVL_40= 324\\n| MIN_SKILL2_LVL_40= 24\\n| MAX_SKILL2_LVL_40= 70\\n\\n| 1STAR_SKILL3_LVL_40= 74\\n| 2STAR_SKILL3_LVL_40= 84\\n| 3STAR_SKILL3_LVL_40= 102\\n| 4STAR_SKILL3_LVL_40= 141\\n| 5STAR_SKILL3_LVL_40= 164\\n| MIN_SKILL3_LVL_40= 11\\n| MAX_SKILL3_LVL_40= 33\\n\\n<!------------ Level 50 ------------>\\n| 1STAR_SKILL1_LVL_50= 268\\n| 2STAR_SKILL1_LVL_50= 276\\n| 3STAR_SKILL1_LVL_50= 319\\n| 4STAR_SKILL1_LVL_50= 381\\n| 5STAR_SKILL1_LVL_50= 444\\n| MIN_SKILL1_LVL_50= 73\\n| MAX_SKILL1_LVL_50= 179\\n\\n| 1STAR_SKILL2_LVL_50= 181\\n| 2STAR_SKILL2_LVL_50= 203\\n| 3STAR_SKILL2_LVL_50= 248\\n| 4STAR_SKILL2_LVL_50= 314\\n| 5STAR_SKILL2_LVL_50= 395\\n| MIN_SKILL2_LVL_50= 28\\n| MAX_SKILL2_LVL_50= 80\\n\\n| 1STAR_SKILL3_LVL_50= 84\\n| 2STAR_SKILL3_LVL_50= 96\\n| 3STAR_SKILL3_LVL_50= 119\\n| 4STAR_SKILL3_LVL_50= 167\\n| 5STAR_SKILL3_LVL_50= 197\\n| MIN_SKILL3_LVL_50= 21\\n| MAX_SKILL3_LVL_50= 73\\n\\n<!------------ Level 60 ------------>\\n| 1STAR_SKILL1_LVL_60= 311\\n| 2STAR_SKILL1_LVL_60= 320\\n| 3STAR_SKILL1_LVL_60= 372\\n| 4STAR_SKILL1_LVL_60= 446\\n| 5STAR_SKILL1_LVL_60= 522\\n| MIN_SKILL1_LVL_60= 99\\n| MAX_SKILL1_LVL_60= 253\\n\\n| 1STAR_SKILL2_LVL_60= 208\\n| 2STAR_SKILL2_LVL_60= 235\\n| 3STAR_SKILL2_LVL_60= 289\\n| 4STAR_SKILL2_LVL_60= 368\\n| 5STAR_SKILL2_LVL_60= 465\\n| MIN_SKILL2_LVL_60= 57\\n| MAX_SKILL2_LVL_60= 165\\n\\n| 1STAR_SKILL3_LVL_60= 104\\n| 2STAR_SKILL3_LVL_60= 118\\n| 3STAR_SKILL3_LVL_60= 145\\n| 4STAR_SKILL3_LVL_60= 203\\n| 5STAR_SKILL3_LVL_60= 239\\n| MIN_SKILL3_LVL_60= 22\\n| MAX_SKILL3_LVL_60= 78\\n\\n<!------------ Level 70 ------------>\\n| 1STAR_SKILL1_LVL_70= 369\\n| 2STAR_SKILL1_LVL_70= 379\\n| 3STAR_SKILL1_LVL_70= 440\\n| 4STAR_SKILL1_LVL_70= 527\\n| 5STAR_SKILL1_LVL_70= 615\\n| MIN_SKILL1_LVL_70= 132\\n| MAX_SKILL1_LVL_70= 320\\n\\n| 1STAR_SKILL2_LVL_70= 276\\n| 2STAR_SKILL2_LVL_70= 307\\n| 3STAR_SKILL2_LVL_70= 370\\n| 4STAR_SKILL2_LVL_70= 463\\n| 5STAR_SKILL2_LVL_70= 576\\n| MIN_SKILL2_LVL_70= 82\\n| MAX_SKILL2_LVL_70= 210\\n\\n| 1STAR_SKILL3_LVL_70= 143\\n| 2STAR_SKILL3_LVL_70= 160\\n| 3STAR_SKILL3_LVL_70= 191\\n| 4STAR_SKILL3_LVL_70= 259\\n| 5STAR_SKILL3_LVL_70= 301\\n| MIN_SKILL3_LVL_70= 62\\n| MAX_SKILL3_LVL_70= 178\\n\\n<!------------ Level 80 ------------>\\n| 1STAR_SKILL1_LVL_80= 426\\n| 2STAR_SKILL1_LVL_80= 438\\n| 3STAR_SKILL1_LVL_80= 508\\n| 4STAR_SKILL1_LVL_80= 607\\n| 5STAR_SKILL1_LVL_80= 708\\n| MIN_SKILL1_LVL_80= 205\\n| MAX_SKILL1_LVL_80= 547\\n\\n| 1STAR_SKILL2_LVL_80= 314\\n| 2STAR_SKILL2_LVL_80= 349\\n| 3STAR_SKILL2_LVL_80= 421\\n| 4STAR_SKILL2_LVL_80= 527\\n| 5STAR_SKILL2_LVL_80= 657\\n| MIN_SKILL2_LVL_80= 92\\n| MAX_SKILL2_LVL_80= 230\\n\\n| 1STAR_SKILL3_LVL_80= 173\\n| 2STAR_SKILL3_LVL_80= 192\\n| 3STAR_SKILL3_LVL_80= 228\\n| 4STAR_SKILL3_LVL_80= 306\\n| 5STAR_SKILL3_LVL_80= 353\\n| MIN_SKILL3_LVL_80= 67\\n| MAX_SKILL3_LVL_80= 193\\n\\n<!------------ Level 90 ------------>\\n| 1STAR_SKILL1_LVL_90= 519\\n| 2STAR_SKILL1_LVL_90= 533\\n| 3STAR_SKILL1_LVL_90= 611\\n| 4STAR_SKILL1_LVL_90= 723\\n| 5STAR_SKILL1_LVL_90= 836\\n| MIN_SKILL1_LVL_90= 270\\n| MAX_SKILL1_LVL_90= 682\\n\\n| 1STAR_SKILL2_LVL_90= 397\\n| 2STAR_SKILL2_LVL_90= 437\\n| 3STAR_SKILL2_LVL_90= 518\\n| 4STAR_SKILL2_LVL_90= 637\\n| 5STAR_SKILL2_LVL_90= 782\\n| MIN_SKILL2_LVL_90= 127\\n| MAX_SKILL2_LVL_90= 295\\n\\n| 1STAR_SKILL3_LVL_90= 182\\n| 2STAR_SKILL3_LVL_90= 204\\n| 3STAR_SKILL3_LVL_90= 244\\n| 4STAR_SKILL3_LVL_90= 332\\n| 5STAR_SKILL3_LVL_90= 385\\n| MIN_SKILL3_LVL_90= 107\\n| MAX_SKILL3_LVL_90= 353\\n\\n<!------------ Level 100 ------------>\\n| 1STAR_SKILL1_LVL_100= 612\\n| 2STAR_SKILL1_LVL_100= 627\\n| 3STAR_SKILL1_LVL_100= 714\\n| 4STAR_SKILL1_LVL_100= 838\\n| 5STAR_SKILL1_LVL_100= 964\\n| MIN_SKILL1_LVL_100= 335\\n| MAX_SKILL1_LVL_100= 817\\n\\n| 1STAR_SKILL2_LVL_100= 450\\n| 2STAR_SKILL2_LVL_100= 494\\n| 3STAR_SKILL2_LVL_100= 584\\n| 4STAR_SKILL2_LVL_100= 716\\n| 5STAR_SKILL2_LVL_100= 878\\n| MIN_SKILL2_LVL_100= 187\\n| MAX_SKILL2_LVL_100= 495\\n\\n| 1STAR_SKILL3_LVL_100= 227\\n| 2STAR_SKILL3_LVL_100= 251\\n| 3STAR_SKILL3_LVL_100= 296\\n| 4STAR_SKILL3_LVL_100= 393\\n| 5STAR_SKILL3_LVL_100= 452\\n| MIN_SKILL3_LVL_100= 122\\n| MAX_SKILL3_LVL_100= 378\\n}}\\n</onlyinclude>\\n\\n== Ship Ability and Bonuses ==\\n{|\\n|-\\n|\\n{| class=\"wikitable\" style=\"text-align:center; font-size:90%;\"\\n! colspan=\"5\" | {{PAGENAME}}'s<br>Passive Ship Stat Bonuses\\n|-\\n| colspan=\"5\" | Only active in {{skill|eng}}, {{skill|sci}}, or {{skill|med}} [[battle stations]]\\n|-\\n! Level\\n| {{skill|passiveacc|}} || {{skill|passivecbonus|}} || {{skill|passivecrating|}} || {{skill|passiveeva|}}\\n|- <!-- Special Character: emdash for 0: \" — \" -->\\n| 1 || — || — || — || —\\n|-\\n| 10 || — || — || — || —\\n|-\\n| 20 || — || — || — || 15\\n|-\\n| 30 || 25 || — || 3 || 15\\n|-\\n| 40 || 25 || — || 3 || 30\\n|-\\n| 50 || 25 || — || 3 || 180\\n|-\\n| 60 || 25 || — || 3 || 205\\n|-\\n| 70 || 25 || — || 3 || 205\\n|-\\n| 80 || 25 || 200 || 3 || 255\\n|-\\n| 90 || 225 || 200 || 73 || 355\\n|-\\n| 100 || 425 || 200 || 113 || 455\\n|}\\n|<onlyinclude>\\n{{ShipAbility\\n| CREW_MAX_SKILL={{{1|}}}\\n| Crew={{PAGENAME}}\\n| Stars   = 5\\n| Ability = eva\\n| 1StarAbilityBoost= 3\\n| BattleQuote = A Debt of Honor\\n| Initialize= 6\\n| Cooldown  = 14\\n| Duration  = 8\\n| BonusAbilitySkillIcon= shield\\n| BonusAbilityText     = +2000 to Shield Regeneration\\n| Trigger          = \\n| ChargePhases1Text= After &nbsp;&nbsp;8s, +2500 to Shield Regeneration\\n| ChargePhases2Text= After 18s, +3000 to Shield Regeneration\\n| HandicapText     = \\n| UsesPerBattle    = \\n}}\\n</onlyinclude>\\n|}\\n\\n==Notes==\\n* {{PAGENAME}} was added February 27, 2018 as the new rare reward in [[The Gauntlet|the Gauntlet]], replacing [[Bartender Guinan]].\\n** He was eventually replaced in the Gauntlet by [[Armus]].\\n\\n==Quotes==\\n*\"quote1\"\\n*\"quote2\"\\n\\n==See Also==\\n{{SACharacter|Caretaker}}\\n\\n{{CrewNav}}\\n\\n[[Category:Star Trek: Voyager]]\\n[[Category:Gauntlet Exclusives]]";
            //WikiData wikiData = new WikiData(wikiText);
            //SkillsRow level = wikiData.parseWikiText();
            //LevelTable levelTable = new LevelTable();
            //levelTable.Levels = new SkillsRow[1];
            //levelTable.WikiName = "The_Caretaker";
            //levelTable.Levels[0] = level;
            //levelTables.Add(levelTable);

            //string wikiName = "Disguised_Kira";
            //WikiData wikiData2 = new WikiData();
            //SkillsRow level2 = wikiData2.parseWikiTextFromPageName(wikiName);
            //level2 = AddBuffs(level2, buffs);
            //LevelTable levelTable2 = new LevelTable();
            //levelTable2.Levels = new SkillsRow[1];
            //levelTable2.WikiName = wikiName;
            //levelTable2.Levels[0] = level2;
            //levelTables.Add(levelTable2);

            //string levelTablesJson = JsonConvert.SerializeObject(levelTables);
            //File.WriteAllText(@"C:\Users\nikea\Desktop\STT\LevelTables.json", levelTablesJson);
            // *** End Get Level 100 skills at all star levels from wiki data ***

            Console.WriteLine("\r\nDone");
            Console.ReadLine();
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
    }
}
