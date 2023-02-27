using Newtonsoft.Json;
using STTDataAnalyzer.Models.PlayerData;
using System;

namespace STTDataAnalyzer.Models.Converters
{
	public class PdGrantedSymbolConverter : JsonConverter
	{
		public override bool CanConvert(Type t)
		{
			return t == typeof(PdGrantedSymbol) || t == typeof(PdGrantedSymbol?);
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
				case "gift_direct_game_item":
					return PdGrantedSymbol.GiftDirectGameItem;
				case "guild_create":
					return PdGrantedSymbol.GuildCreate;
				case "guild_squad_create":
					return PdGrantedSymbol.GuildSquadCreate;
				case "monthly_card_daily_collect":
					return PdGrantedSymbol.MonthlyCardDailyCollect;
				case "niners_avatar":
					return PdGrantedSymbol.NinersAvatar;
			}
			throw new Exception("Cannot unmarshal type PdGrantedSymbol");
		}

		public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
		{
			if (untypedValue == null)
			{
				serializer.Serialize(writer, null);
				return;
			}
			var value = (PdGrantedSymbol)untypedValue;
			switch (value)
			{
				case PdGrantedSymbol.GiftDirectGameItem:
					serializer.Serialize(writer, "gift_direct_game_item");
					return;
				case PdGrantedSymbol.GuildCreate:
					serializer.Serialize(writer, "guild_create");
					return;
				case PdGrantedSymbol.GuildSquadCreate:
					serializer.Serialize(writer, "guild_squad_create");
					return;
			}
			throw new Exception("Cannot marshal type PdGrantedSymbol");
		}

		public static readonly PdGrantedSymbolConverter Singleton = new PdGrantedSymbolConverter();
	}
}
