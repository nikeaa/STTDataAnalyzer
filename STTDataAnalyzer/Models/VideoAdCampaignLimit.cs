﻿namespace STTDataAnalyzer
{

	// <auto-generated />
	//
	// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
	//
	//    using SttUser;
	//
	//    var welcome = Welcome.FromJson(jsonString);

	namespace SttUser
	{
		using Newtonsoft.Json;

		public partial class VideoAdCampaignLimit
		{
			[JsonProperty("master_limit")]
			public MasterLimit MasterLimit { get; set; }

			[JsonProperty("stt_rewarded_scan")]
			public MasterLimit SttRewardedScan { get; set; }

			[JsonProperty("stt_rewarded_warp")]
			public MasterLimit SttRewardedWarp { get; set; }

			[JsonProperty("stt_cadet_warp")]
			public MasterLimit SttCadetWarp { get; set; }

			[JsonProperty("stt_rewarded_shuttle")]
			public MasterLimit SttRewardedShuttle { get; set; }

			[JsonProperty("stt_rewarded_credits")]
			public MasterLimit SttRewardedCredits { get; set; }

			[JsonProperty("stt_rewarded_dabo")]
			public MasterLimit SttRewardedDabo { get; set; }

			[JsonProperty("stt_rewarded_chroniton_boost")]
			public MasterLimit SttRewardedChronitonBoost { get; set; }

			[JsonProperty("stt_rewarded_double_rewards")]
			public MasterLimit SttRewardedDoubleRewards { get; set; }
		}
	}
}