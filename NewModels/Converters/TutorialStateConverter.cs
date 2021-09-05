using Newtonsoft.Json;
using STTDataAnalyzer.Models.PlayerData;
using System;

namespace STTDataAnalyzer.Models.Converters
{
	public class PdTutorialStateConverter : JsonConverter
	{
		public override bool CanConvert(Type t)
		{
			return t == typeof(PdTutorialState) || t == typeof(PdTutorialState?);
		}

		public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.Null)
			{
				return null;
			}

			var value = serializer.Deserialize<string>(reader);
			if (value == "completed")
			{
				return PdTutorialState.Completed;
			}
			throw new Exception("Cannot unmarshal type PdTutorialState");
		}

		public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
		{
			if (untypedValue == null)
			{
				serializer.Serialize(writer, null);
				return;
			}
			var value = (PdTutorialState)untypedValue;
			if (value == PdTutorialState.Completed)
			{
				serializer.Serialize(writer, "completed");
				return;
			}
			throw new Exception("Cannot marshal type PdTutorialState");
		}

		public static readonly PdTutorialStateConverter Singleton = new PdTutorialStateConverter();
	}
}
