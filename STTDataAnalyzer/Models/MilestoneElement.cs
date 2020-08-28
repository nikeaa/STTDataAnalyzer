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

		public partial class MilestoneElement
		{
			[JsonProperty("goal")]
			public long Goal { get; set; }

			[JsonProperty("rewards")]
			public List<MilestoneReward> Rewards { get; set; }

			[JsonProperty("claimed")]
			public bool Claimed { get; set; }

			[JsonProperty("claimable")]
			public bool Claimable { get; set; }
		}
	}
}