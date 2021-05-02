using System.Runtime.Serialization;

namespace STTDataAnalyzer.Models.PlayerData
{
	public enum PdOperator
	{
		[EnumMember(Value = "increment")]
		Increment,
		[EnumMember(Value = "multiplier")]
		Multiplier,
		[EnumMember(Value = "percent_decrease")]
		PercentDecrease,
		[EnumMember(Value = "percent_increase")]
		PercentIncrease
	};
}
