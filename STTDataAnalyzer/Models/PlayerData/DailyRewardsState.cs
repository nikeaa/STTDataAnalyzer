using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdDailyRewardsState
	{
		[JsonProperty("seconds_until_next_reward")]
		public long SecondsUntilNextReward { get; set; }

		[JsonProperty("today_reward_day_index")]
		public long TodayRewardDayIndex { get; set; }

		[JsonProperty("season_points_per_day")]
		public long SeasonPointsPerDay { get; set; }

		[JsonProperty("reward_days")]
		public List<PdRewardDay> RewardDays { get; set; }
	}
}
