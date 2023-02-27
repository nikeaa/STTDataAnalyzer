using Newtonsoft.Json;
using STTDataAnalyzer.Models.PlayerData;
using System;

namespace STTDataAnalyzer.Models.Converters
{
	public class PdFullNameEnumConverter : JsonConverter
	{
		public override bool CanConvert(Type t)
		{
			return t == typeof(PdFullNameEnum) || t == typeof(PdFullNameEnum?);
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
				case "Advanced Replicator Ration":
					return PdFullNameEnum.AdvancedReplicatorRation;
				case "Chronitons":
					return PdFullNameEnum.Chronitons;
				case "Dilithium":
					return PdFullNameEnum.Dilithium;
				case "Federation Credits":
					return PdFullNameEnum.FederationCredits;
				case "Honor":
					return PdFullNameEnum.Honor;
				case "Merits":
					return PdFullNameEnum.Merits;
				case "Premium Time Portal":
					return PdFullNameEnum.PremiumTimePortal;
				case "10x Premium Time Portal":
					return PdFullNameEnum.PremiumTimePortal10x;
				case "Dynamic Replicator Ration":
					return PdFullNameEnum.DynamicReplicatorRation;
				case "The Niners":
					return PdFullNameEnum.TheNiners;
				case "Interstellar Medium":
					return PdFullNameEnum.InterstellarMedium;
			}
			throw new Exception("Cannot unmarshal type PdFullNameEnum");
		}

		public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
		{
			if (untypedValue == null)
			{
				serializer.Serialize(writer, null);
				return;
			}
			var value = (PdFullNameEnum)untypedValue;
			switch (value)
			{
				case PdFullNameEnum.AdvancedReplicatorRation:
					serializer.Serialize(writer, "Advanced Replicator Ration");
					return;
				case PdFullNameEnum.Chronitons:
					serializer.Serialize(writer, "Chronitons");
					return;
				case PdFullNameEnum.Dilithium:
					serializer.Serialize(writer, "Dilithium");
					return;
				case PdFullNameEnum.FederationCredits:
					serializer.Serialize(writer, "Federation Credits");
					return;
				case PdFullNameEnum.Honor:
					serializer.Serialize(writer, "Honor");
					return;
				case PdFullNameEnum.Merits:
					serializer.Serialize(writer, "Merits");
					return;
				case PdFullNameEnum.PremiumTimePortal:
					serializer.Serialize(writer, "Premium Time Portal");
					return;
			}
			throw new Exception("Cannot marshal type PdFullNameEnum");
		}

		public static readonly PdFullNameEnumConverter Singleton = new PdFullNameEnumConverter();
	}
}
