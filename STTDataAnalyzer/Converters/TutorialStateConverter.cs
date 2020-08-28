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

		internal class TutorialStateConverter : JsonConverter
		{
			public override bool CanConvert(Type t)
			{
				return t == typeof(TutorialState) || t == typeof(TutorialState?);
			}

			public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
			{
				if (reader.TokenType == JsonToken.Null)
				{
					return null;
				}

				var value = serializer.Deserialize<string>(reader);
				if (value == "completed")
				{
					return TutorialState.Completed;
				}
				throw new Exception("Cannot unmarshal type TutorialState");
			}

			public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
			{
				if (untypedValue == null)
				{
					serializer.Serialize(writer, null);
					return;
				}
				var value = (TutorialState)untypedValue;
				if (value == TutorialState.Completed)
				{
					serializer.Serialize(writer, "completed");
					return;
				}
				throw new Exception("Cannot marshal type TutorialState");
			}

			public static readonly TutorialStateConverter Singleton = new TutorialStateConverter();
		}
	}
}