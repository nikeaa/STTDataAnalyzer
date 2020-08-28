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
		using System.Collections.Generic;

		public partial class DailyRewardsState
		{
			[JsonProperty("seconds_until_next_reward")]
			public long SecondsUntilNextReward { get; set; }

			[JsonProperty("today_reward_day_index")]
			public long TodayRewardDayIndex { get; set; }

			[JsonProperty("season_points_per_day")]
			public long SeasonPointsPerDay { get; set; }

			[JsonProperty("reward_days")]
			public List<RewardDay> RewardDays { get; set; }
		}
	}
}
