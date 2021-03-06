using System;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PlayerData
	{
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
						am += 0;
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

						int minScoreToPass = (int)(((time / 60)) / 0.0499);

						if (skillScore >= minScoreToPass) am += 5; else am -= 30;
					}
					else
					{
						am -= 1;
					}
				}

				totalTime += time;
			}

			return totalTime;
		}
	}
}
