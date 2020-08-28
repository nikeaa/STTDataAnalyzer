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

		public partial class ShipBattle
		{
			[JsonProperty("accuracy", NullValueHandling = NullValueHandling.Ignore)]
			public long? Accuracy { get; set; }

			[JsonProperty("evasion", NullValueHandling = NullValueHandling.Ignore)]
			public long? Evasion { get; set; }

			[JsonProperty("crit_chance", NullValueHandling = NullValueHandling.Ignore)]
			public long? CritChance { get; set; }

			[JsonProperty("crit_bonus", NullValueHandling = NullValueHandling.Ignore)]
			public long? CritBonus { get; set; }
		}
	}
}
