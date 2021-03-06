using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdArchetype
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("type")]
		public long Type { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("icon")]
		public PdIconClass Icon { get; set; }

		[JsonProperty("flavor")]
		public string Flavor { get; set; }

		[JsonProperty("rarity")]
		public long Rarity { get; set; }

		[JsonProperty("recipe", NullValueHandling = NullValueHandling.Ignore)]
		public PdRecipe Recipe { get; set; }

		[JsonProperty("item_sources")]
		public List<PdItemSource> ItemSources { get; set; }

		[JsonProperty("bonuses", NullValueHandling = NullValueHandling.Ignore)]
		public Dictionary<string, long> Bonuses { get; set; }

		[JsonProperty("short_name", NullValueHandling = NullValueHandling.Ignore)]
		public string ShortName { get; set; }
	}
}
