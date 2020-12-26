using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace STTDataAnalyzer.Models
{
	public class SkillSet
	{
		public Dictionary<string, int> Skills; // by skill
	}

	public class Level
	{
		public int LevelNumber;
		public SkillSet[] Skills; // by star count
		public Dictionary<string, int> MinProficiency; // by skill
		public Dictionary<string, int> MaxProficiency; // by skill
	}

	public class LevelTable
	{
		public Level[] Levels;
	}

	public class WikiData
	{
		private string[] skills = new string[3];
		private string _wikiText = "";

		public WikiData () {
		}

		public WikiData(string wikiText)
		{
			_wikiText = wikiText;
			skills = getSkillNames(_wikiText);
		}

		public Level parseWikiTextFromPageName(string pageName) {
			// get the text from the wiki based on the name.
			string uri = string.Format("https://stt.wiki/w/api.php?action=query&format=json&prop=revisions&titles={0}&formatversion=2&rvprop=content&rvslots=*", pageName);

			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
			request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
			using (Stream stream = response.GetResponseStream())
			using (StreamReader reader = new StreamReader(stream))
			{
				_wikiText = reader.ReadToEnd().Replace("\\\\n", "\\n");
			}

			skills = getSkillNames(_wikiText);
			return parseWikiText();
		}

		//1STAR_SKILL1_LVL_100
		//string[,] skills = new string[5,3];
		//string[,] mods = new string[2,3];
		public Level parseWikiText(string wikiText)
		{
			_wikiText = wikiText;
			skills = getSkillNames(_wikiText);
			return parseWikiText();
		}

		public Level parseWikiText()
		{
			Level result = new Level
			{
				LevelNumber = 100,
				Skills = new SkillSet[5],
				MinProficiency = new Dictionary<string, int>(),
				MaxProficiency = new Dictionary<string, int>()
			};

			int skillCount = 2 + (skills[2] != null ? 1 : 0);
			for (int star = 0; star < 5; star++)
			{
				SkillSet skillSet = new SkillSet();
				skillSet.Skills = new Dictionary<string, int>();
				for (int skill = 0; skill < skillCount; skill++)
				{
					string key = (star + 1).ToString() + "STAR_SKILL" + (skill + 1).ToString() + "_LVL_100";
					string value = GetValue(_wikiText, key);
					skillSet.Skills.Add(skills[skill], int.Parse(value));
					//MIN_SKILL1_LVL_100= 335\n| 
					if (star == 0)
					{
						key = "MIN_SKILL" + (skill + 1).ToString() + "_LVL_100";
						result.MinProficiency.Add(skills[skill], int.Parse(GetValue(_wikiText, key)));
						key = "MAX_SKILL" + (skill + 1).ToString() + "_LVL_100";
						result.MaxProficiency.Add(skills[skill], int.Parse(GetValue(_wikiText, key)));
					}
				}
				result.Skills[star] = skillSet;
			}

			return result;
		}

		private static string GetValue(string text, string key)
		{
			string result = null;

			//SKILL_1= eng\n| 
			if (!string.IsNullOrEmpty(key))
			{
				key += "= ";
				int keyPos = text.IndexOf(key);
				if (keyPos > -1)
				{
					int valueStart = keyPos + key.Length;
					int valueEnd = text.IndexOf("\\n", valueStart);
					result = text.Substring(valueStart, valueEnd - valueStart);
				}
			}

			return result;
		}

		private string[] getSkillNames(string wikiText)
		{
			string[] result = new string[3];

			result[0] = GetValue(wikiText, "SKILL_1");
			result[1] = GetValue(wikiText, "SKILL_2");
			result[2] = GetValue(wikiText, "SKILL_3");

			return result;
		}
	}
}
