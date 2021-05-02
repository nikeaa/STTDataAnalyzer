using System.Runtime.Serialization;

namespace STTDataAnalyzer.Models.PlayerData
{
	public enum PdGrantedSymbol
	{
		[EnumMember(Value = "gift_direct_game_item")]
		GiftDirectGameItem,
		[EnumMember(Value = "guild_create")]
		GuildCreate,
		[EnumMember(Value = "guild_squad_create")]
		GuildSquadCreate,
		[EnumMember(Value = "monthly_card_daily_collect")]
		MonthlyCardDailyCollect,
		[EnumMember(Value = "niners_avatar")]
		NinersAvatar
	};
}
