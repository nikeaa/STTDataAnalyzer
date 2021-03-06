namespace STTDataAnalyzer.Converters
{
	using Newtonsoft.Json;
	using STTDataAnalyzer.Models.PlayerData;
	using System;

	public class PdVideoAdChronitonBoostRewardSymbolConverter : JsonConverter
	{
		public override bool CanConvert(Type t)
		{
			return t == typeof(PdVideoAdChronitonBoostRewardSymbol) || t == typeof(PdVideoAdChronitonBoostRewardSymbol?);
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
				case "energy":
					return PdVideoAdChronitonBoostRewardSymbol.Energy;
				case "honor":
					return PdVideoAdChronitonBoostRewardSymbol.Honor;
				case "nonpremium":
					return PdVideoAdChronitonBoostRewardSymbol.Nonpremium;
				case "premium_1x_bundle":
					return PdVideoAdChronitonBoostRewardSymbol.Premium1XBundle;
				case "premium_earnable":
					return PdVideoAdChronitonBoostRewardSymbol.PremiumEarnable;
				case "premium_purchasable":
					return PdVideoAdChronitonBoostRewardSymbol.PremiumPurchasable;
				case "replicator_fuel_superrare":
					return PdVideoAdChronitonBoostRewardSymbol.ReplicatorFuelSuperrare;
				case "replicator_fuel_legendary":
					return PdVideoAdChronitonBoostRewardSymbol.ReplicatorFuelLegendary;
				case "premium_10x_bundle":
					return PdVideoAdChronitonBoostRewardSymbol.Premium10XBundle;
				case "niners_avatar":
					return PdVideoAdChronitonBoostRewardSymbol.NinersAvatar;
				case "ism_subcoin":
					return PdVideoAdChronitonBoostRewardSymbol.IsmSubCoin;
			}
			throw new Exception("Cannot unmarshal type PdVideoAdChronitonBoostRewardSymbol");
		}

		public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
		{
			if (untypedValue == null)
			{
				serializer.Serialize(writer, null);
				return;
			}
			var value = (PdVideoAdChronitonBoostRewardSymbol)untypedValue;
			switch (value)
			{
				case PdVideoAdChronitonBoostRewardSymbol.Energy:
					serializer.Serialize(writer, "energy");
					return;
				case PdVideoAdChronitonBoostRewardSymbol.Honor:
					serializer.Serialize(writer, "honor");
					return;
				case PdVideoAdChronitonBoostRewardSymbol.Nonpremium:
					serializer.Serialize(writer, "nonpremium");
					return;
				case PdVideoAdChronitonBoostRewardSymbol.Premium1XBundle:
					serializer.Serialize(writer, "premium_1x_bundle");
					return;
				case PdVideoAdChronitonBoostRewardSymbol.PremiumEarnable:
					serializer.Serialize(writer, "premium_earnable");
					return;
				case PdVideoAdChronitonBoostRewardSymbol.PremiumPurchasable:
					serializer.Serialize(writer, "premium_purchasable");
					return;
				case PdVideoAdChronitonBoostRewardSymbol.ReplicatorFuelSuperrare:
					serializer.Serialize(writer, "replicator_fuel_superrare");
					return;
				case PdVideoAdChronitonBoostRewardSymbol.NinersAvatar:
					serializer.Serialize(writer, "niners_avatar");
					return;
			}
			throw new Exception("Cannot marshal type PdVideoAdChronitonBoostRewardSymbol");
		}

		public static readonly PdVideoAdChronitonBoostRewardSymbolConverter Singleton = new PdVideoAdChronitonBoostRewardSymbolConverter();
	}
}
