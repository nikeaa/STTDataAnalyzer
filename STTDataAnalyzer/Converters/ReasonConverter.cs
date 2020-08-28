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

		internal class ReasonConverter : JsonConverter
		{
			public override bool CanConvert(Type t)
			{
				return t == typeof(Reason) || t == typeof(Reason?);
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
					return Reason.Reward;
				}
				throw new Exception("Cannot unmarshal type Reason");
			}

			public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
			{
				if (untypedValue == null)
				{
					serializer.Serialize(writer, null);
					return;
				}
				var value = (Reason)untypedValue;
				if (value == Reason.Reward)
				{
					serializer.Serialize(writer, "reward");
					return;
				}
				throw new Exception("Cannot marshal type Reason");
			}

			public static readonly ReasonConverter Singleton = new ReasonConverter();
		}
	}
}