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

		public partial class DisputeHistory
		{
			[JsonProperty("id")]
			public long Id { get; set; }

			[JsonProperty("symbol")]
			public string Symbol { get; set; }

			[JsonProperty("name")]
			public string Name { get; set; }

			[JsonProperty("episode")]
			public long Episode { get; set; }

			[JsonProperty("marker")]
			public List<long> Marker { get; set; }

			[JsonProperty("completed")]
			public bool Completed { get; set; }

			[JsonProperty("mission_ids")]
			public List<long> MissionIds { get; set; }

			[JsonProperty("stars_earned")]
			public long StarsEarned { get; set; }

			[JsonProperty("total_stars")]
			public long TotalStars { get; set; }

			[JsonProperty("exclude_from_timeline")]
			public bool ExcludeFromTimeline { get; set; }

			[JsonProperty("faction_id")]
			public long FactionId { get; set; }
		}
	}
}