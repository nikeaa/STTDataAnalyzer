using Newtonsoft.Json;
using STTDataAnalyzer.Converters;
using STTDataAnalyzer.Models.Static;
using System;
using System.Collections.Generic;

namespace STTDataAnalyzer
{
	public class SingleValueArrayConverter<T> : JsonConverter
	{
		public override bool CanConvert(Type t)
		{
			return t == typeof(List<IntermediateSkillData>);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			object retVal = new Object();

			if (reader.TokenType == JsonToken.StartObject)
			{
				T instance = (T)serializer.Deserialize(reader, typeof(T));
				retVal = new List<T>() { instance };
			}
			else if (reader.TokenType == JsonToken.StartArray)
			{
				retVal = serializer.Deserialize(reader, objectType);
			}

			return retVal;
		}

		public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
		{
			throw new Exception("Cannot marshal type Ranks");
		}

		public static readonly BaseSkillsConverter Singleton = new BaseSkillsConverter();
	}
}
