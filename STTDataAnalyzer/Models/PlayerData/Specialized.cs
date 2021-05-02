using System.Runtime.Serialization;

namespace STTDataAnalyzer.Models.PlayerData
{
	public enum PdSpecialized
	{
		[EnumMember(Value = "premium_10x_bundle")]
		Premium10XBundle,
		[EnumMember(Value = "premium_1x_bundle")]
		Premium1XBundle,
		[EnumMember(Value = "minor_consumables_10x_bundle")]
		MinorConsumables10XBundle,
		[EnumMember(Value = "premium_consumables_10x_bundle")]
		PremiumConsumables10XBundle,
		[EnumMember(Value = "standard_10x_bundle")]
		Standard10XBundle,
		[EnumMember(Value = "standard_consumables_10x_bundle")]
		StandardConsumables10XBundle,
		[EnumMember(Value = "stimpack_bundle")]
		StimpackBundle,
		[EnumMember(Value = "standard_1x_bundle")]
		Standard1XBundle
	};
}
