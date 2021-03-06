﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class DailyActivity
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("icon")]
		public PdIcon Icon { get; set; }

		[JsonProperty("area")]
		public string Area { get; set; }

		[JsonProperty("weight")]
		public long Weight { get; set; }

		[JsonProperty("category")]
		public long Category { get; set; }

		[JsonProperty("lifetime", NullValueHandling = NullValueHandling.Ignore)]
		public long? Lifetime { get; set; }

		[JsonProperty("rewards", NullValueHandling = NullValueHandling.Ignore)]
		public List<ShuttleTokenPreviewItem> Rewards { get; set; }

		[JsonProperty("goal", NullValueHandling = NullValueHandling.Ignore)]
		public long? Goal { get; set; }

		[JsonProperty("min_level", NullValueHandling = NullValueHandling.Ignore)]
		public long? MinLevel { get; set; }

		[JsonProperty("rarity", NullValueHandling = NullValueHandling.Ignore)]
		public long? Rarity { get; set; }

		[JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
		public long? Progress { get; set; }

		[JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
		public string Status { get; set; }
	}
}
