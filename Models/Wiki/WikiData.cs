using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text;

namespace STTDataAnalyzer.Models.Wiki
{
//	public class SkillSet
//	{
//		public Dictionary<string, int> CoreSkills; // by skill
//	}

	public class SkillsRow
	{
		public int LevelNumber;
		public Dictionary<string, int>[] CoreSkills; // by star count
		public Dictionary<string, int> MinProficiency; // by skill
		public Dictionary<string, int> MaxProficiency; // by skill
	}

	public class LevelTable
	{
		public string WikiName;
		public SkillsRow[] Levels;
	}

	public class WikiData : BaseData
	{
		private string[] skills = new string[3];
		private string _wikiText = "";

		public WikiData () {
		}

		public WikiData(string wikiText)
		{
			_wikiText = wikiText;
			skills = GetSkillNames(_wikiText);
		}

		public SkillsRow parseWikiTextFromPageName(string pageName) {
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

			skills = GetSkillNames(_wikiText);
			return parseWikiText();
		}

		//1STAR_SKILL1_LVL_100
		//string[,] skills = new string[5,3];
		//string[,] mods = new string[2,3];
		public SkillsRow parseWikiText(string wikiText)
		{
			_wikiText = wikiText;
			skills = GetSkillNames(_wikiText);
			return parseWikiText();
		}

		public SkillsRow parseWikiText()
		{
			SkillsRow result = new SkillsRow
			{
				LevelNumber = 100,
				CoreSkills = new Dictionary<string, int>[5],
				MinProficiency = new Dictionary<string, int>(),
				MaxProficiency = new Dictionary<string, int>()
			};

			int skillCount = 2 + (skills[2] != null ? 1 : 0);
			for (int star = 0; star < 5; star++)
			{
				result.CoreSkills[star] = new Dictionary<string, int>();
				//SkillSet skillSet = new SkillSet();
				//skillSet.Skills = new Dictionary<string, int>();
				for (int skill = 0; skill < skillCount; skill++)
				{
					string key = (star + 1).ToString() + "STAR_SKILL" + (skill + 1).ToString() + "_LVL_100";
					string value = GetValue(_wikiText, key);
					result.CoreSkills[star].Add(skills[skill], int.Parse(value));
					//skillSet.Skills.Add(skills[skill], int.Parse(value));
					//MIN_SKILL1_LVL_100= 335\n| 
					if (star == 0)
					{
						key = "MIN_SKILL" + (skill + 1).ToString() + "_LVL_100";
						result.MinProficiency.Add(skills[skill], int.Parse(GetValue(_wikiText, key)));
						key = "MAX_SKILL" + (skill + 1).ToString() + "_LVL_100";
						result.MaxProficiency.Add(skills[skill], int.Parse(GetValue(_wikiText, key)));
					}
				}
				//result.CoreSkills[star] = skillSet;
			}

			return result;
		}

		private static string GetValue(string text, string key)
		{
			string result = null;

			if (!string.IsNullOrEmpty(key))
			{
				key += "= ";
				int keyPos = text.IndexOf(key);
				if (keyPos > -1)
				{
					int valueStart = keyPos + key.Length;
					int valueEnd = text.IndexOf("\\n", valueStart);
					result = text.Substring(valueStart, valueEnd - valueStart);
					if (result.IndexOf(" ") > -1) {
						valueEnd = result.IndexOf(" ");
						result = result.Substring(0, valueEnd);
					}
				}
			}

			return result;
		}

		private string[] GetSkillNames(string wikiText)
		{
			string[] result = new string[3];

			result[0] = GetSkillFullName(GetValue(wikiText, "SKILL_1"));
			result[1] = GetSkillFullName(GetValue(wikiText, "SKILL_2"));
			result[2] = GetSkillFullName(GetValue(wikiText, "SKILL_3"));

			return result;
		}

		private string GetSkillFullName(string skillShortName)
		{
			if (skillShortName != null)
			{
				switch (skillShortName.ToLower())
				{
					case "cmd": return CommandSkillName;
					case "dip": return DiplomacySkillName;
					case "eng": return EngineeringSkillName;
					case "med": return MedicineSkillName;
					case "sci": return ScienceSkillName;
					case "sec": return SecuritySkillName;
				}
			}

			return null;
		}
	}
}
