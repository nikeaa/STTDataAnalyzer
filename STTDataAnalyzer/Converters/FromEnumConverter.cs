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

		internal class FromEnumConverter : JsonConverter
		{
			public override bool CanConvert(Type t)
			{
				return t == typeof(FromEnum) || t == typeof(FromEnum?);
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
					case "Member join success after invite {gid=Some(1047137872764935)}":
						return FromEnum.MemberJoinSuccessAfterInviteGidSome1047137872764935;
					case "Member join success after invite {gid=Some(888574811693058)}":
						return FromEnum.MemberJoinSuccessAfterInviteGidSome888574811693058;
					case "claimed":
						return FromEnum.Claimed;
					case "granted":
						return FromEnum.Granted;
					case "reverted":
						return FromEnum.Reverted;
				}
				throw new Exception("Cannot unmarshal type FromEnum");
			}

			public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
			{
				if (untypedValue == null)
				{
					serializer.Serialize(writer, null);
					return;
				}
				var value = (FromEnum)untypedValue;
				switch (value)
				{
					case FromEnum.MemberJoinSuccessAfterInviteGidSome1047137872764935:
						serializer.Serialize(writer, "Member join success after invite {gid=Some(1047137872764935)}");
						return;
					case FromEnum.MemberJoinSuccessAfterInviteGidSome888574811693058:
						serializer.Serialize(writer, "Member join success after invite {gid=Some(888574811693058)}");
						return;
					case FromEnum.Claimed:
						serializer.Serialize(writer, "claimed");
						return;
					case FromEnum.Granted:
						serializer.Serialize(writer, "granted");
						return;
					case FromEnum.Reverted:
						serializer.Serialize(writer, "reverted");
						return;
				}
				throw new Exception("Cannot marshal type FromEnum");
			}

			public static readonly FromEnumConverter Singleton = new FromEnumConverter();
		}
	}
}