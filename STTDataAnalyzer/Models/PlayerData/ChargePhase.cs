namespace STTDataAnalyzer.Models.PlayerData
{
	using Newtonsoft.Json;

	public partial class ChargePhase
	{
		[JsonProperty("charge_time")]
		public long ChargeTime { get; set; }

		[JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
		public long? Duration { get; set; }

		[JsonProperty("cooldown", NullValueHandling = NullValueHandling.Ignore)]
		public long? Cooldown { get; set; }

		[JsonProperty("bonus_amount", NullValueHandling = NullValueHandling.Ignore)]
		public long? BonusAmount { get; set; }

		[JsonProperty("ability_amount", NullValueHandling = NullValueHandling.Ignore)]
		public long? AbilityAmount { get; set; }
	}
}
