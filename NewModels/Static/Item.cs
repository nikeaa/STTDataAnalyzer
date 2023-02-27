using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class Item
	{
		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("type")]
		public int Type { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("flavor")]
		public string Flavor { get; set; }

		[JsonProperty("rarity")]
		public int Rarity { get; set; }

		[JsonProperty("item_sources")]
		public ItemSource[] ItemSources { get; set; }

		[JsonProperty("short_name")]
		public string ShortName { get; set; }

		[JsonProperty("imageUrl")]
		public string ImageUrl { get; set; }
	}
}
