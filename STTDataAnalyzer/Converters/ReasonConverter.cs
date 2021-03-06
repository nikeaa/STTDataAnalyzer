namespace STTDataAnalyzer.Converters
{
	using Newtonsoft.Json;
	using STTDataAnalyzer.Models.PlayerData;
	using System;

	public class PdReasonConverter : JsonConverter
	{
		public override bool CanConvert(Type t)
		{
			return t == typeof(PdReason) || t == typeof(PdReason?);
		}

		public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.Null)
			{
				return null;
			}

			var value = serializer.Deserialize<string>(reader);
			if (value == "reward")
			{
				return PdReason.Reward;
			}
			throw new Exception("Cannot unmarshal type PdReason");
		}

		public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
		{
			if (untypedValue == null)
			{
				serializer.Serialize(writer, null);
				return;
			}
			var value = (PdReason)untypedValue;
			if (value == PdReason.Reward)
			{
				serializer.Serialize(writer, "reward");
				return;
			}
			throw new Exception("Cannot marshal type PdReason");
		}

		public static readonly PdReasonConverter Singleton = new PdReasonConverter();
	}
}
