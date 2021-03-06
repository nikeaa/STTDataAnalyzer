using Newtonsoft.Json;
using STTDataAnalyzer.Models.PlayerData;
using System;

namespace STTDataAnalyzer.Converters
{
	public class PdFromEnumConverter : JsonConverter
	{
		public override bool CanConvert(Type t)
		{
			return t == typeof(PdFromEnum) || t == typeof(PdFromEnum?);
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
					return PdFromEnum.MemberJoinSuccessAfterInviteGidSome1047137872764935;
				case "Member join success after invite {gid=Some(888574811693058)}":
					return PdFromEnum.MemberJoinSuccessAfterInviteGidSome888574811693058;
				case "claimed":
					return PdFromEnum.Claimed;
				case "granted":
					return PdFromEnum.Granted;
				case "reverted":
					return PdFromEnum.Reverted;
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
			var value = (PdFromEnum)untypedValue;
			switch (value)
			{
				case PdFromEnum.MemberJoinSuccessAfterInviteGidSome1047137872764935:
					serializer.Serialize(writer, "Member join success after invite {gid=Some(1047137872764935)}");
					return;
				case PdFromEnum.MemberJoinSuccessAfterInviteGidSome888574811693058:
					serializer.Serialize(writer, "Member join success after invite {gid=Some(888574811693058)}");
					return;
				case PdFromEnum.Claimed:
					serializer.Serialize(writer, "claimed");
					return;
				case PdFromEnum.Granted:
					serializer.Serialize(writer, "granted");
					return;
				case PdFromEnum.Reverted:
					serializer.Serialize(writer, "reverted");
					return;
			}
			throw new Exception("Cannot marshal type FromEnum");
		}

		public static readonly PdFromEnumConverter Singleton = new PdFromEnumConverter();
	}
}
