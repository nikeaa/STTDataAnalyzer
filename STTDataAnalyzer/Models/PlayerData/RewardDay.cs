using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdRewardDay
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("rewards")]
		public List<PdRewardDayReward> Rewards { get; set; }

		[JsonProperty("double_at_vip", NullValueHandling = NullValueHandling.Ignore)]
		public long? DoubleAtVip { get; set; }
	}
}
