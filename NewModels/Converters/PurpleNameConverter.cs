using Newtonsoft.Json;
using STTDataAnalyzer.Models.PlayerData;
using System;

namespace STTDataAnalyzer.Models.Converters
{
	public class PdPurpleNameConverter : JsonConverter
	{
		public override bool CanConvert(Type t)
		{
			return t == typeof(PdPurpleName) || t == typeof(PdPurpleName?);
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
				case "Chronitons":
					return PdPurpleName.Chronitons;
				case "Credits":
					return PdPurpleName.Credits;
				case "Dilithium":
					return PdPurpleName.Dilithium;
				case "Honor":
					return PdPurpleName.Honor;
				case "Merits":
					return PdPurpleName.Merits;
				case "Portal":
					return PdPurpleName.Portal;
				case "10x Portal":
					return PdPurpleName.Portal10x;
				case "Replicator Fuel":
					return PdPurpleName.ReplicatorFuel;
				case "The Niners":
					return PdPurpleName.TheNiners;
				case "ISM":
					return PdPurpleName.ISM;
			}
			throw new Exception("Cannot unmarshal type PdPurpleName");
		}

		public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
		{
			if (untypedValue == null)
			{
				serializer.Serialize(writer, null);
				return;
			}
			var value = (PdPurpleName)untypedValue;
			switch (value)
			{
				case PdPurpleName.Chronitons:
					serializer.Serialize(writer, "Chronitons");
					return;
				case PdPurpleName.Credits:
					serializer.Serialize(writer, "Credits");
					return;
				case PdPurpleName.Dilithium:
					serializer.Serialize(writer, "Dilithium");
					return;
				case PdPurpleName.Honor:
					serializer.Serialize(writer, "Honor");
					return;
				case PdPurpleName.Merits:
					serializer.Serialize(writer, "Merits");
					return;
				case PdPurpleName.Portal:
					serializer.Serialize(writer, "Portal");
					return;
				case PdPurpleName.ReplicatorFuel:
					serializer.Serialize(writer, "Replicator Fuel");
					return;
			}
			throw new Exception("Cannot marshal type PdPurpleName");
		}

		public static readonly PdPurpleNameConverter Singleton = new PdPurpleNameConverter();
	}
}
