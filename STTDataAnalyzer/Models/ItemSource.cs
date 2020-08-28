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

		public partial class ItemSource
		{
			[JsonProperty("challenge_id", NullValueHandling = NullValueHandling.Ignore)]
			public long? ChallengeId { get; set; }

			[JsonProperty("challenge_skill", NullValueHandling = NullValueHandling.Ignore)]
			public SkillElement? ChallengeSkill { get; set; }

			[JsonProperty("challenge_difficulty", NullValueHandling = NullValueHandling.Ignore)]
			public long? ChallengeDifficulty { get; set; }

			[JsonProperty("type")]
			public long Type { get; set; }

			[JsonProperty("id")]
			public long Id { get; set; }

			[JsonProperty("name")]
			public string Name { get; set; }

			[JsonProperty("energy_quotient")]
			public double EnergyQuotient { get; set; }

			[JsonProperty("chance_grade")]
			public long ChanceGrade { get; set; }

			[JsonProperty("place", NullValueHandling = NullValueHandling.Ignore)]
			public string Place { get; set; }

			[JsonProperty("mission", NullValueHandling = NullValueHandling.Ignore)]
			public long? Mission { get; set; }

			[JsonProperty("dispute", NullValueHandling = NullValueHandling.Ignore)]
			public long? Dispute { get; set; }

			[JsonProperty("mastery", NullValueHandling = NullValueHandling.Ignore)]
			public long? Mastery { get; set; }
		}
	}
}