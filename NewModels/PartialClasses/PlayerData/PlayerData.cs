using NewUtilities;
using System;
using System.Configuration;
using System.IO;
using System.Net.Http;
using System.Text;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PlayerData
	{
        private static string FileName = ConfigurationManager.AppSettings["PlayerDataFileName"];
        private static string FileNameAndPath = Directory.GetCurrentDirectory() + "\\Data\\" + FileName;

        public static string RetrieveFromDB()
        {
            string result = "";

            OAuth oAuth = new OAuth();
            string token = oAuth.GetToken("nikeaa@gmail.com", "Winter64!", "4fc852d7-d602-476a-a292-d243022a475d", "password");

            string data = $"{{\"client_api\": \"12\", \"access_token\": \"{token}\"}}";
            string url = $"https://stt.disruptorbeam.com/player?{data}";

            try
            {
                using (HttpClient client = new HttpClient())
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
            catch
            {
                result = null;
            }

            return result;
        }
    }
}
