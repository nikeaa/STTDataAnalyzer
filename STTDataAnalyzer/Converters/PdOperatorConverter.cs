using Newtonsoft.Json;
using STTDataAnalyzer.Models.PlayerData;
using System;

namespace STTDataAnalyzer.Converters
{
	public class PdOperatorConverter : JsonConverter
	{
		public override bool CanConvert(Type t)
		{
			return t == typeof(PdOperator) || t == typeof(PdOperator?);
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
				case "increment":
					return PdOperator.Increment;
				case "multiplier":
					return PdOperator.Multiplier;
				case "percent_decrease":
					return PdOperator.PercentDecrease;
				case "percent_increase":
					return PdOperator.PercentIncrease;
			}
			throw new Exception("Cannot unmarshal type PdOperator");
		}

		public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
		{
			if (untypedValue == null)
			{
				serializer.Serialize(writer, null);
				return;
			}
			var value = (PdOperator)untypedValue;
			switch (value)
			{
				case PdOperator.Increment:
					serializer.Serialize(writer, "increment");
					return;
				case PdOperator.Multiplier:
					serializer.Serialize(writer, "multiplier");
					return;
				case PdOperator.PercentDecrease:
					serializer.Serialize(writer, "percent_decrease");
					return;
				case PdOperator.PercentIncrease:
					serializer.Serialize(writer, "percent_increase");
					return;
			}
			throw new Exception("Cannot marshal type PdOperator");
		}

		public static readonly PdOperatorConverter Singleton = new PdOperatorConverter();
	}
}
