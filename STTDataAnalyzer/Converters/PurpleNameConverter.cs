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

		internal class PurpleNameConverter : JsonConverter
		{
			public override bool CanConvert(Type t)
			{
				return t == typeof(PurpleName) || t == typeof(PurpleName?);
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
						return PurpleName.Chronitons;
					case "Credits":
						return PurpleName.Credits;
					case "Dilithium":
						return PurpleName.Dilithium;
					case "Honor":
						return PurpleName.Honor;
					case "Merits":
						return PurpleName.Merits;
					case "Portal":
						return PurpleName.Portal;
					case "10x Portal":
						return PurpleName.Portal10x;
					case "Replicator Fuel":
						return PurpleName.ReplicatorFuel;
				}
				throw new Exception("Cannot unmarshal type PurpleName");
			}

			public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
			{
				if (untypedValue == null)
				{
					serializer.Serialize(writer, null);
					return;
				}
				var value = (PurpleName)untypedValue;
				switch (value)
				{
					case PurpleName.Chronitons:
						serializer.Serialize(writer, "Chronitons");
						return;
					case PurpleName.Credits:
						serializer.Serialize(writer, "Credits");
						return;
					case PurpleName.Dilithium:
						serializer.Serialize(writer, "Dilithium");
						return;
					case PurpleName.Honor:
						serializer.Serialize(writer, "Honor");
						return;
					case PurpleName.Merits:
						serializer.Serialize(writer, "Merits");
						return;
					case PurpleName.Portal:
						serializer.Serialize(writer, "Portal");
						return;
					case PurpleName.ReplicatorFuel:
						serializer.Serialize(writer, "Replicator Fuel");
						return;
				}
				throw new Exception("Cannot marshal type PurpleName");
			}

			public static readonly PurpleNameConverter Singleton = new PurpleNameConverter();
		}
	}
}