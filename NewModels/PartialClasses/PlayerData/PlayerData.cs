using NewUtilities;
using System;
using System.Configuration;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PlayerData
	{
        private static string FileName = ConfigurationManager.AppSettings["PlayerDataFileName"];
        private static string FilePath = Directory.GetCurrentDirectory() + "\\Data\\";
        private static string FileNameAndPath = FilePath + FileName;

        private static string ProgramDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName;
        private static string PlayerDataFileName = $@"{ProgramDirectory}\NewModels\PlayerData.cs";
        private static string PlayerDataCode = File.ReadAllText(PlayerDataFileName);
        public static bool PlayerDataCodeChanged = false;

        public static string Get(bool forceFromWeb = false)
        {
            string result = null;

            bool retrievedInLast24Hours = true;

            if (!File.Exists(FilePath + "nextRetrievalFromDB.txt"))
            {
                retrievedInLast24Hours = false;
            }
            else
            {
                string nextRetrievalDateString = File.ReadAllText(FilePath + "nextRetrievalFromDB.txt");
                DateTime nextRetrievalDate = DateTime.Parse(nextRetrievalDateString);
                if (DateTime.Now > nextRetrievalDate)
                {
                    retrievedInLast24Hours = false;
                }
            }

            if (forceFromWeb || !retrievedInLast24Hours)
            {
                result = RetrieveFromDB();
                File.WriteAllText(FileNameAndPath, result);
                File.WriteAllText(FilePath + "nextRetrievalFromDB.txt", DateTime.Now.AddDays(1).ToShortDateString());
            }
            else
            {
                result = ReadFromFile();
            }

            return result;
        }

        public static string RetrieveFromDB()
        {
            string result = "";

            OAuth oAuth = new OAuth();
            string token = oAuth.GetToken("nikeaa@gmail.com", "Winter64!", "4fc852d7-d602-476a-a292-d243022a475d", "password");

            string data = $"{{\"client_api\": \"12\", \"access_token\": \"{token}\"}}";
            string url = $"https://stt.disruptorbeam.com/player?{data}";

            try
            {
                var handler = new WinHttpHandler();
                using (HttpClient client = new HttpClient(handler))
                {
                    client.BaseAddress = new Uri("https://stt.disruptorbeam.com");

                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "/player");
                    request.Content = new StringContent(data, Encoding.UTF8, "application/json");

                    using (HttpResponseMessage response = client.SendAsync(request).Result)
                    {
                        using (HttpContent content = response.Content)
                        {
                            result = content.ReadAsStringAsync().Result;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                result = "";
            }


            return result;
        }

        public static void UpdatePlayerDataCode() {
            if (PlayerDataCodeChanged) {
                File.WriteAllText(PlayerDataFileName, PlayerDataCode);
            }
        }

        public static void AddEnumValueToCode(string value, string enumName)
        {
            string enumValueName = Regex.Replace(value, @"_[a-zA-Z]", m => m.ToString().ToUpper().Replace("_", ""));
            enumValueName = Regex.Replace(enumValueName, @"^[a-z]", m => m.ToString().ToUpper()).Replace(" ", "").Replace(".","").Replace("1x", "OneX").Replace("10x", "TenX");

            if (PlayerDataCode.IndexOf($"return {enumName}.{enumValueName}") < 0)
            {
                string newEnumValue = $@"
                case ""{value}"":
                    return {enumName}.{enumValueName};";

                string insertString = $"// {enumName}.Insert";
                int insertPos = PlayerDataCode.IndexOf(insertString) + insertString.Length;
                PlayerDataCode = PlayerDataCode.Insert(insertPos, newEnumValue);

                PlayerDataCodeChanged = true;
            }

            int enumPos = PlayerDataCode.IndexOf($"public enum {enumName} ");
            int enumInsertPos = PlayerDataCode.IndexOf(";", enumPos) - 8;
            if (!TextInLine(enumInsertPos, enumValueName))
            {
                PlayerDataCode = PlayerDataCode.Insert(enumInsertPos, $", {enumValueName}");

                PlayerDataCodeChanged = true;
            }
        }

		private static bool TextInLine(int enumInsertPos, string enumValueName)
		{
            int endPos = enumInsertPos + 8;
            int startPos = endPos - 1;
            while (PlayerDataCode[startPos]  != '{') {
                startPos--;
			}

            string line = PlayerDataCode.Substring(startPos, endPos - startPos + 1);

            return line.IndexOf(enumValueName) > -1;
		}

		public static int GetVoyageTimeEstimate(int goldSkill, int silverSkill, int bronzeSkill1, int bronzeSkill2, int bronzeSkill3, int bronzeSkill4, int startingAm, int estimateIterations = 1000)
		{
			int am;
			int totalTime = 0;
			int time;
			for (int i = 0; i < estimateIterations; i++)
			{
				am = startingAm;

				for (time = 20; time < 60 * 60 * 30 && am > 0; time += 20)
				{
					if (time % 7200 == 0)
					{
						am += 0; // dilemma
					}
					else if (time % 80 == 0 && time % 560 != 0)
					{
						// hazard
						int skillScore = 0;

						Random random = new Random();
						int skillRoll = random.Next(1, 101);
						if (skillRoll <= 35) skillScore = goldSkill;
						else if (skillRoll <= 60) skillScore = silverSkill;
						else if (skillRoll <= 70) skillScore = bronzeSkill1;
						else if (skillRoll <= 80) skillScore = bronzeSkill2;
						else if (skillRoll <= 90) skillScore = bronzeSkill3;
						else skillScore = bronzeSkill4;

                        //int minScoreToPass = (int)(((time / 60)) / 0.0499);
                        int minScoreToPass = time / 3; // 1200 per hour, 3600 seconds in an hour

						if (skillScore >= minScoreToPass) am += 5; else am -= 30;

                        //Console.WriteLine($"Hazard: {skillRoll} : {skillScore} : {minScoreToPass}");
					}
					else
			    	{
						am -= 1;
					}
				}

                //Console.WriteLine($"Voyage Time: {time}");
                //Console.ReadLine();

				totalTime += time;
			}

			return totalTime / estimateIterations;
		}

        public static int GetVoyageTimeEstimate(Skill primary, Skill secondary, Skill tertiary1, Skill tertiary2, Skill tertiary3, Skill tertiary4, int startingAm, int estimateIterations = 1000)
        {
            int am;
            long totalTime = 0;
            int time;
            for (int i = 0; i < estimateIterations; i++)
            {
                am = startingAm;

                for (time = 20; time < 60 * 60 * 30 && am > 0; time += 20)
                {
                    if (time % 7200 == 0)
                    {
                        am += 0; // dilemma
                    }
                    else if (time % 80 == 0 && time % 560 != 0)
                    {
                        // hazard
                        Skill skill = null;

                        Random random = new Random();
                        int skillRoll = random.Next(1, 101);
                        if (skillRoll <= 35) skill = primary;
                        else if (skillRoll <= 60) skill = secondary;
                        else if (skillRoll <= 70) skill = tertiary1;
                        else if (skillRoll <= 80) skill = tertiary2;
                        else if (skillRoll <= 90) skill = tertiary3;
                        else skill = tertiary4;

                        long skillScore = skill.Core + random.Next((int)skill.RangeMin, (int)(skill.RangeMax + 1));

                        int minScoreToPass = time / 3; // 1200 per hour, 3600 seconds in an hour

                        if (skillScore >= minScoreToPass) am += 5; else am -= 30;
                    }
                    else
                    {
                        am -= 1;
                    }
                }

                totalTime += time;
            }

            return (int)(totalTime / estimateIterations);
        }

        public static string ReadFromFile()
        {
            string result = null;

            try
            {
                result = File.ReadAllText(FileNameAndPath);
            }
            catch (Exception ex)
            {
                result = null;
            }

            return result;
        }
    }
}
