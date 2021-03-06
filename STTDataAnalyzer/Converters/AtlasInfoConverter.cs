using Newtonsoft.Json;
using STTDataAnalyzer.Models.PlayerData;
using System;

namespace STTDataAnalyzer.Converters
	{
		public class PdAtlasInfoConverter : JsonConverter
		{
			public override bool CanConvert(Type t)
			{
				return t == typeof(PdAtlasInfo) || t == typeof(PdAtlasInfo?);
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
					case "atlas_stt_icons2_info":
						return PdAtlasInfo.AtlasSttIcons2Info;
					case "atlas_stt_icons_info":
						return PdAtlasInfo.AtlasSttIconsInfo;
					case "atlas_stt_forte_info":
						return PdAtlasInfo.AtlasSttForteInfo;
				}
				throw new Exception("Cannot unmarshal type AtlasInfo");
			}

			public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
			{
				if (untypedValue == null)
				{
					serializer.Serialize(writer, null);
					return;
				}
				var value = (PdAtlasInfo)untypedValue;
				switch (value)
				{
					case PdAtlasInfo.AtlasSttIcons2Info:
						serializer.Serialize(writer, "atlas_stt_icons2_info");
						return;
					case PdAtlasInfo.AtlasSttIconsInfo:
						serializer.Serialize(writer, "atlas_stt_icons_info");
						return;
				}
				throw new Exception("Cannot marshal type AtlasInfo");
			}

			public static readonly PdAtlasInfoConverter Singleton = new PdAtlasInfoConverter();
		}
	}
