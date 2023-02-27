using Newtonsoft.Json;
using STTDataAnalyzer.Models.PlayerData;
using System;

namespace STTDataAnalyzer.Models.Converters
{
	public class PdSourceConverter : JsonConverter
	{
		public override bool CanConvert(Type t)
		{
			return t == typeof(PdSource) || t == typeof(PdSource?);
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
				case "crew_collection":
					return PdSource.CrewCollection;
				case "starbase":
					return PdSource.Starbase;
			}
			throw new Exception("Cannot unmarshal type PdSource");
		}

		public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
		{
			if (untypedValue == null)
			{
				serializer.Serialize(writer, null);
				return;
			}
			var value = (PdSource)untypedValue;
			switch (value)
			{
				case PdSource.CrewCollection:
					serializer.Serialize(writer, "crew_collection");
					return;
				case PdSource.Starbase:
					serializer.Serialize(writer, "starbase");
					return;
			}
			throw new Exception("Cannot marshal type PdSource");
		}

		public static readonly PdSourceConverter Singleton = new PdSourceConverter();
	}
}
