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

		public partial class MilestoneReward
		{
			[JsonProperty("type")]
			public long Type { get; set; }

			[JsonProperty("id")]
			public long Id { get; set; }

			[JsonProperty("symbol")]
			public VideoAdChronitonBoostRewardSymbol Symbol { get; set; }

			[JsonProperty("name")]
			public PurpleName Name { get; set; }

			[JsonProperty("full_name")]
			public FullNameEnum FullName { get; set; }

			[JsonProperty("flavor")]
			public string Flavor { get; set; }

			[JsonProperty("icon")]
			public Icon Icon { get; set; }

			[JsonProperty("quantity")]
			public long Quantity { get; set; }

			[JsonProperty("rarity")]
			public long Rarity { get; set; }

			[JsonProperty("item_type", NullValueHandling = NullValueHandling.Ignore)]
			public long? ItemType { get; set; }
		}
	}
}
