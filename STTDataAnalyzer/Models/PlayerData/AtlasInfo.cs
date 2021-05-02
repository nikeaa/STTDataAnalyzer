using System.Runtime.Serialization;

namespace STTDataAnalyzer.Models.PlayerData
{
	public enum PdAtlasInfo
	{
		[EnumMember(Value = "atlas_stt_icons2_info")]
		AtlasSttIcons2Info,
		[EnumMember(Value = "atlas_stt_icons_info")]
		AtlasSttIconsInfo,
		[EnumMember(Value = "atlas_stt_forte_info")]
		AtlasSttForteInfo
	};
}
