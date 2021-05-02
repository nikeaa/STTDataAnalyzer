using System.Runtime.Serialization;

namespace STTDataAnalyzer.Models.PlayerData
{
	public enum PdFromEnum
	{
		[EnumMember(Value = "claimed")]
		Claimed,
		[EnumMember(Value = "granted")]
		Granted,
		[EnumMember(Value = "Member join success after invite {gid=Some(1047137872764935)}")]
		MemberJoinSuccessAfterInviteGidSome1047137872764935,
		[EnumMember(Value = "Member join success after invite {gid=Some(888574811693058)}")]
		MemberJoinSuccessAfterInviteGidSome888574811693058,
		[EnumMember(Value = "reverted")]
		Reverted
	};
}
