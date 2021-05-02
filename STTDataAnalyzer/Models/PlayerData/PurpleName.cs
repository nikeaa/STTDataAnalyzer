using System.Runtime.Serialization;

namespace STTDataAnalyzer.Models.PlayerData
{
	public enum PdPurpleName
	{
		[EnumMember(Value = "Chronitons")]
		Chronitons,
		[EnumMember(Value = "Credits")]
		Credits,
		[EnumMember(Value = "Dilithium")]
		Dilithium,
		[EnumMember(Value = "Honor")]
		Honor,
		[EnumMember(Value = "Merits")]
		Merits,
		[EnumMember(Value = "Portal")]
		Portal,
		[EnumMember(Value = "10x Portal")]
		Portal10x,
		[EnumMember(Value = "Replicator Fuel")]
		ReplicatorFuel,
		[EnumMember(Value = "The Niners")]
		TheNiners,
		[EnumMember(Value = "ISM")]
		ISM
	};
}
