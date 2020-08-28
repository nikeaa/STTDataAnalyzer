﻿namespace STTDataAnalyzer
{

	// <auto-generated />
	//
	// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
	//
	//    using SttUser;
	//
	//    var welcome = Welcome.FromJson(jsonString);

	namespace SttUser
	{
		using Newtonsoft.Json;
		using System;

		internal class VideoAdChronitonBoostRewardSymbolConverter : JsonConverter
		{
			public override bool CanConvert(Type t)
			{
				return t == typeof(VideoAdChronitonBoostRewardSymbol) || t == typeof(VideoAdChronitonBoostRewardSymbol?);
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
						return VideoAdChronitonBoostRewardSymbol.Energy;
					case "honor":
						return VideoAdChronitonBoostRewardSymbol.Honor;
					case "nonpremium":
						return VideoAdChronitonBoostRewardSymbol.Nonpremium;
					case "premium_1x_bundle":
						return VideoAdChronitonBoostRewardSymbol.Premium1XBundle;
					case "premium_earnable":
						return VideoAdChronitonBoostRewardSymbol.PremiumEarnable;
					case "premium_purchasable":
						return VideoAdChronitonBoostRewardSymbol.PremiumPurchasable;
					case "replicator_fuel_superrare":
						return VideoAdChronitonBoostRewardSymbol.ReplicatorFuelSuperrare;
					case "replicator_fuel_legendary":
						return VideoAdChronitonBoostRewardSymbol.ReplicatorFuelLegendary;
					case "premium_10x_bundle":
						return VideoAdChronitonBoostRewardSymbol.Premium10XBundle;
				}
				throw new Exception("Cannot unmarshal type VideoAdChronitonBoostRewardSymbol");
			}

			public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
			{
				if (untypedValue == null)
				{
					serializer.Serialize(writer, null);
					return;
				}
				var value = (VideoAdChronitonBoostRewardSymbol)untypedValue;
				switch (value)
				{
					case VideoAdChronitonBoostRewardSymbol.Energy:
						serializer.Serialize(writer, "energy");
						return;
					case VideoAdChronitonBoostRewardSymbol.Honor:
						serializer.Serialize(writer, "honor");
						return;
					case VideoAdChronitonBoostRewardSymbol.Nonpremium:
						serializer.Serialize(writer, "nonpremium");
						return;
					case VideoAdChronitonBoostRewardSymbol.Premium1XBundle:
						serializer.Serialize(writer, "premium_1x_bundle");
						return;
					case VideoAdChronitonBoostRewardSymbol.PremiumEarnable:
						serializer.Serialize(writer, "premium_earnable");
						return;
					case VideoAdChronitonBoostRewardSymbol.PremiumPurchasable:
						serializer.Serialize(writer, "premium_purchasable");
						return;
					case VideoAdChronitonBoostRewardSymbol.ReplicatorFuelSuperrare:
						serializer.Serialize(writer, "replicator_fuel_superrare");
						return;
				}
				throw new Exception("Cannot marshal type VideoAdChronitonBoostRewardSymbol");
			}

			public static readonly VideoAdChronitonBoostRewardSymbolConverter Singleton = new VideoAdChronitonBoostRewardSymbolConverter();
		}
	}
}