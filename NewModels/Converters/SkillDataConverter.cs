using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using STTDataAnalyzer.Models.Static;
using System;
using System.Collections.Generic;
using System.Linq;

namespace STTDataAnalyzer
{
	public class SkillDataConverter : JsonConverter
	{
		public override bool CanConvert(Type t)
		{
			return t == typeof(List<Skill>);
		}

		public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
		{
			List<Skill>[] skills = new List<Skill>[6];
			for (int x = 1; x < 6; x++) skills[x] = new List<Skill>();

			string[] skillNames = new string[] { "Command", "Diplomacy", "Engineering", "Medicine", "Science", "Security" };

			if (reader.TokenType == JsonToken.Null)
				return null;

			var tokens = JToken.Load(reader);

			for (int rarity = 1; rarity <= tokens.Count(); rarity++)
			{
				var skillForRarity = tokens[rarity - 1];

				foreach (string skillName in skillNames)
				{
					string token = skillName.ToLower() + "_skill";
					if (skillForRarity["base_skills"][token] != null)
					{
						skills[rarity].Add(new Skill()
						{
							Name = skillName + "Skill",
							Base = skillForRarity["base_skills"][token]["core"].Value<int>(),
							RangeMin = skillForRarity["base_skills"][token]["range_min"].Value<int>(),
							RangeMax = skillForRarity["base_skills"][token]["range_max"].Value<int>()
						});
					}
				}
			}

			return skills;
		}

		public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
		{
			throw new Exception("Cannot marshal type Ranks");
		}

		public static readonly SkillDataConverter Singleton = new SkillDataConverter();
	}
}
