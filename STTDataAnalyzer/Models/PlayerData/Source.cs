using System.Runtime.Serialization;

namespace STTDataAnalyzer.Models.PlayerData
{
	public enum PdSource
	{
		[EnumMember(Value = "crew_collection")]
		CrewCollection,
		[EnumMember(Value = "starbase")]
		Starbase
	};
}
