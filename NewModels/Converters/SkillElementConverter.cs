using Newtonsoft.Json;
using STTDataAnalyzer.Models.PlayerData;
using System;

namespace STTDataAnalyzer.Models.Converters
{
	internal class PdSkillElementConverter : JsonConverter
	{
		public override bool CanConvert(Type t)
		{
			return t == typeof(PdSkillElement) || t == typeof(PdSkillElement?);
		}

		public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.Null)
			{
				return null;
			}

			var value = serializer.Deserialize<string>(reader);
			switch (value)
			{
				case "command_skill":
					return PdSkillElement.CommandSkill;
				case "diplomacy_skill":
					return PdSkillElement.DiplomacySkill;
				case "engineering_skill":
					return PdSkillElement.EngineeringSkill;
				case "medicine_skill":
					return PdSkillElement.MedicineSkill;
				case "science_skill":
					return PdSkillElement.ScienceSkill;
				case "security_skill":
					return PdSkillElement.SecuritySkill;
			}
			throw new Exception("Cannot unmarshal type PdSkillElement");
		}

		public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
		{
			if (untypedValue == null)
			{
				serializer.Serialize(writer, null);
				return;
			}
			var value = (PdSkillElement)untypedValue;
			switch (value)
			{
				case PdSkillElement.CommandSkill:
					serializer.Serialize(writer, "command_skill");
					return;
				case PdSkillElement.DiplomacySkill:
					serializer.Serialize(writer, "diplomacy_skill");
					return;
				case PdSkillElement.EngineeringSkill:
					serializer.Serialize(writer, "engineering_skill");
					return;
				case PdSkillElement.MedicineSkill:
					serializer.Serialize(writer, "medicine_skill");
					return;
				case PdSkillElement.ScienceSkill:
					serializer.Serialize(writer, "science_skill");
					return;
				case PdSkillElement.SecuritySkill:
					serializer.Serialize(writer, "security_skill");
					return;
			}
			throw new Exception("Cannot marshal type PdSkillElement");
		}

		public static readonly PdSkillElementConverter Singleton = new PdSkillElementConverter();
	}
}
