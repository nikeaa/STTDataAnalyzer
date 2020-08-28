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

		public partial class CrewAction
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
			public long Crew { get; set; }

			[JsonProperty("icon")]
			public IconClass Icon { get; set; }

			[JsonProperty("ability", NullValueHandling = NullValueHandling.Ignore)]
			public Ability Ability { get; set; }

			[JsonProperty("penalty", NullValueHandling = NullValueHandling.Ignore)]
			public Penalty Penalty { get; set; }

			[JsonProperty("special")]
			public bool Special { get; set; }

			[JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
			public long? Limit { get; set; }

			[JsonProperty("charge_phases", NullValueHandling = NullValueHandling.Ignore)]
			public List<ChargePhase> ChargePhases { get; set; }
		}
	}
}
