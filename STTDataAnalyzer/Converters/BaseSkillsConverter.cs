using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using STTDataAnalyzer.Models.Static;
using System;
using System.Collections.Generic;

namespace STTDataAnalyzer.Converters
{
	public class BaseSkillsConverter : JsonConverter
	{
		public override bool CanConvert(Type t)
		{
			return t == typeof(List<Skill>);
		}

		public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
		{
			List<Skill> skills = new List<Skill>();

			string[] skillNames = new string[] { "Command", "Diplomacy", "Engineering", "Medicine", "Science", "Security" };

			if (reader.TokenType == JsonToken.Null)
				return null;

			var tokens = JToken.Load(reader);

			foreach (string skillName in skillNames) {
				string token = skillName.ToLower() + "_skill";
				if (tokens[token] != null) {
					skills.Add(new Skill()
					{
						Name = skillName + "Skill",
						Base = tokens[token]["core"].Value<int>(),
						RangeMin = tokens[token]["range_min"].Value<int>(),
						RangeMax = tokens[token]["range_max"].Value<int>()
					});
				}
			}

			return skills;
		}

		public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
		{
			throw new Exception("Cannot marshal type Ranks");
		}

		public static readonly BaseSkillsConverter Singleton = new BaseSkillsConverter();
	}
}
