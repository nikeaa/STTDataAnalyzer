using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class Faction
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("icon")]
		public string Icon { get; set; }

		[JsonProperty("representative_icon")]
		public string RepresentativeIcon { get; set; }

		[JsonProperty("reputation_item_icon")]
		public string ReputationItemIcon { get; set; }

		[JsonProperty("home_system")]
		public string HomeSystem { get; set; }

		[JsonProperty("shop_layout")]
		public string ShopLayout { get; set; }

		[JsonProperty("shuttle_token_id")]
		public int ShuttleTokenId { get; set; }

		[JsonProperty("shuttle_token_item_icon")]
		public string ShuttleTokenItemIcon { get; set; }
	}
}
