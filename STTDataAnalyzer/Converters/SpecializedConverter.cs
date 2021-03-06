using Newtonsoft.Json;
using STTDataAnalyzer.Models.PlayerData;
using System;

namespace STTDataAnalyzer.Converters
{
	public class PdSpecializedConverter : JsonConverter
	{
		public override bool CanConvert(Type t)
		{
			return t == typeof(PdSpecialized) || t == typeof(PdSpecialized?);
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
				case "premium_10x_bundle":
					return PdSpecialized.Premium10XBundle;
				case "premium_1x_bundle":
					return PdSpecialized.Premium1XBundle;
				case "premium_consumables_10x_bundle":
					return PdSpecialized.PremiumConsumables10XBundle;
				case "standard_10x_bundle":
					return PdSpecialized.Standard10XBundle;
				case "standard_consumables_10x_bundle":
					return PdSpecialized.StandardConsumables10XBundle;
				case "stimpack_bundle":
					return PdSpecialized.StimpackBundle;
				case "standard_1x_bundle":
					return PdSpecialized.Standard1XBundle;
				case "minor_consumables_10x_bundle":
					return PdSpecialized.MinorConsumables10XBundle;
			}
			throw new Exception("Cannot unmarshal type PdSpecialized");
		}

		public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
		{
			if (untypedValue == null)
			{
				serializer.Serialize(writer, null);
				return;
			}
			var value = (PdSpecialized)untypedValue;
			switch (value)
			{
				case PdSpecialized.Premium10XBundle:
					serializer.Serialize(writer, "premium_10x_bundle");
					return;
				case PdSpecialized.Premium1XBundle:
					serializer.Serialize(writer, "premium_1x_bundle");
					return;
				case PdSpecialized.PremiumConsumables10XBundle:
					serializer.Serialize(writer, "premium_consumables_10x_bundle");
					return;
				case PdSpecialized.Standard10XBundle:
					serializer.Serialize(writer, "standard_10x_bundle");
					return;
				case PdSpecialized.StandardConsumables10XBundle:
					serializer.Serialize(writer, "standard_consumables_10x_bundle");
					return;
				case PdSpecialized.StimpackBundle:
					serializer.Serialize(writer, "stimpack_bundle");
					return;
			}
			throw new Exception("Cannot marshal type PdSpecialized");
		}

		public static readonly PdSpecializedConverter Singleton = new PdSpecializedConverter();
	}
}
