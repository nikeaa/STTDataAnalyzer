using System.Runtime.Serialization;

namespace STTDataAnalyzer.Models.PlayerData
{
	public enum PdVideoAdChronitonBoostRewardSymbol
	{
		[EnumMember(Value = "energy")]
		Energy,
		[EnumMember(Value = "honor")]
		Honor,
		[EnumMember(Value = "nonpremium")]
		Nonpremium,
		[EnumMember(Value = "premium_1x_bundle")]
		Premium1XBundle,
		[EnumMember(Value = "premium_10x_bundle")]
		Premium10XBundle,
		[EnumMember(Value = "premium_earnable")]
		PremiumEarnable,
		[EnumMember(Value = "premium_purchasable")]
		PremiumPurchasable,
		[EnumMember(Value = "replicator_fuel_superrare")]
		ReplicatorFuelSuperrare,
		[EnumMember(Value = "replicator_fuel_legendary")]
		ReplicatorFuelLegendary,
		[EnumMember(Value = "niners_avatar")]
		NinersAvatar,
		[EnumMember(Value = "ism_subcoin")]
		IsmSubCoin
	};
}
