﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class ShuttleTokenPreviewItem
	{
		[JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
		public long? Id { get; set; }

		[JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
		public string Symbol { get; set; }

		[JsonProperty("type")]
		public long Type { get; set; }

		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
		public string Name { get; set; }

		[JsonProperty("icon")]
		public PdIconClass Icon { get; set; }

		[JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
		public string Flavor { get; set; }

		[JsonProperty("rarity", NullValueHandling = NullValueHandling.Ignore)]
		public long? Rarity { get; set; }

		[JsonProperty("item_sources", NullValueHandling = NullValueHandling.Ignore)]
		public List<object> ItemSources { get; set; }

		[JsonProperty("full_name", NullValueHandling = NullValueHandling.Ignore)]
		public string FullName { get; set; }

		[JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
		public long? Quantity { get; set; }

		[JsonProperty("potential_rewards", NullValueHandling = NullValueHandling.Ignore)]
		public List<ShuttleTokenPreviewItem> PotentialRewards { get; set; }

		[JsonProperty("item_type", NullValueHandling = NullValueHandling.Ignore)]
		public long? ItemType { get; set; }

		[JsonProperty("bonuses", NullValueHandling = NullValueHandling.Ignore)]
		public Dictionary<string, long> Bonuses { get; set; }

		[JsonProperty("faction_id", NullValueHandling = NullValueHandling.Ignore)]
		public long? FactionId { get; set; }
	}
}
