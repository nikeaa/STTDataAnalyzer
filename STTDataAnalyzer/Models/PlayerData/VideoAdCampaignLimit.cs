using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdVideoAdCampaignLimit
	{
		[JsonProperty("master_limit")]
		public PdMasterLimit MasterLimit { get; set; }

		[JsonProperty("stt_rewarded_scan")]
		public PdMasterLimit SttRewardedScan { get; set; }

		[JsonProperty("stt_rewarded_warp")]
		public PdMasterLimit SttRewardedWarp { get; set; }

		[JsonProperty("stt_cadet_warp")]
		public PdMasterLimit SttCadetWarp { get; set; }

		[JsonProperty("stt_rewarded_shuttle")]
		public PdMasterLimit SttRewardedShuttle { get; set; }

		[JsonProperty("stt_rewarded_credits")]
		public PdMasterLimit SttRewardedCredits { get; set; }

		[JsonProperty("stt_rewarded_dabo")]
		public PdMasterLimit SttRewardedDabo { get; set; }

		[JsonProperty("stt_rewarded_chroniton_boost")]
		public PdMasterLimit SttRewardedChronitonBoost { get; set; }

		[JsonProperty("stt_rewarded_double_rewards")]
		public PdMasterLimit SttRewardedDoubleRewards { get; set; }
	}
}
