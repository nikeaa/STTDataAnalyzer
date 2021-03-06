using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdActionElement
	{
		[JsonProperty("bonus_amount")]
		public long BonusAmount { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("cooldown")]
		public long Cooldown { get; set; }

		[JsonProperty("initial_cooldown")]
		public long InitialCooldown { get; set; }

		[JsonProperty("duration")]
		public long Duration { get; set; }

		[JsonProperty("bonus_type")]
		public long BonusType { get; set; }

		[JsonProperty("crew")]
		public long? Crew { get; set; }

		[JsonProperty("icon")]
		public PdIconClass Icon { get; set; }

		[JsonProperty("special")]
		public bool Special { get; set; }

		[JsonProperty("ability", NullValueHandling = NullValueHandling.Ignore)]
		public PdAbility Ability { get; set; }

		[JsonProperty("penalty", NullValueHandling = NullValueHandling.Ignore)]
		public PdPenalty Penalty { get; set; }

		[JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
		public long? Status { get; set; }

		[JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
		public long? Limit { get; set; }

		[JsonProperty("charge_phases", NullValueHandling = NullValueHandling.Ignore)]
		public List<ChargePhase> ChargePhases { get; set; }
	}
}
