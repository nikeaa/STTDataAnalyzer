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

		public partial class VoyageDescription
		{
			[JsonProperty("id")]
			public long Id { get; set; }

			[JsonProperty("symbol")]
			public string Symbol { get; set; }

			[JsonProperty("name")]
			public string Name { get; set; }

			[JsonProperty("description")]
			public string Description { get; set; }

			[JsonProperty("icon")]
			public string Icon { get; set; }

			[JsonProperty("skills")]
			public VoyageDescriptionSkills Skills { get; set; }

			[JsonProperty("ship_trait")]
			public string ShipTrait { get; set; }

			[JsonProperty("crew_slots")]
			public List<CrewSlot> CrewSlots { get; set; }

			[JsonProperty("potential_rewards")]
			public List<PotentialReward> PotentialRewards { get; set; }
		}
	}
}
