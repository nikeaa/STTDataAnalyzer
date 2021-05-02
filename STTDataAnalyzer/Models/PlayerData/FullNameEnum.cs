using System.Runtime.Serialization;

namespace STTDataAnalyzer.Models.PlayerData
{
	public enum PdFullNameEnum
	{
		[EnumMember(Value = "Advanced Replicator Ration")]
		AdvancedReplicatorRation,
		[EnumMember(Value = "Dynamic Replicator Ration")]
		DynamicReplicatorRation,
		[EnumMember(Value = "Chronitons")]
		Chronitons,
		[EnumMember(Value = "Dilithium")]
		Dilithium,
		[EnumMember(Value = "Federation Credits")]
		FederationCredits,
		[EnumMember(Value = "Honor")]
		Honor,
		[EnumMember(Value = "Merits")]
		Merits,
		[EnumMember(Value = "Premium Time Portal")]
		PremiumTimePortal,
		[EnumMember(Value = "10x Premium Time Portal")]
		PremiumTimePortal10x,
		[EnumMember(Value = "The Niners")]
		TheNiners,
		[EnumMember(Value = "Interstellar Medium")]
		InterstellarMedium
	};
}
