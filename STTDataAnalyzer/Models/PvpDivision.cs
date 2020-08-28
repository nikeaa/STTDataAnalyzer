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

		public partial class PvpDivision
		{
			[JsonProperty("id")]
			public long Id { get; set; }

			[JsonProperty("tier")]
			public long Tier { get; set; }

			[JsonProperty("name")]
			public string Name { get; set; }

			[JsonProperty("description")]
			public string Description { get; set; }

			[JsonProperty("min_ship_rarity")]
			public long MinShipRarity { get; set; }

			[JsonProperty("max_ship_rarity")]
			public long MaxShipRarity { get; set; }

			[JsonProperty("max_crew_rarity")]
			public long MaxCrewRarity { get; set; }

			[JsonProperty("setup")]
			public Setup Setup { get; set; }
		}
	}
}
