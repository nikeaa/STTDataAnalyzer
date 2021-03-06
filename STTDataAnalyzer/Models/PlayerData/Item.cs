using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
	{
		public partial class PdItem
		{
			[JsonProperty("id")]
			public long Id { get; set; }

			[JsonProperty("type")]
			public long Type { get; set; }

			[JsonProperty("symbol")]
			public string Symbol { get; set; }

			[JsonProperty("name")]
			public string Name { get; set; }

			[JsonProperty("flavor")]
			public string Flavor { get; set; }

			[JsonProperty("archetype_id")]
			public long ArchetypeId { get; set; }

			[JsonProperty("quantity")]
			public long Quantity { get; set; }

			[JsonProperty("icon")]
			public PdIconClass Icon { get; set; }

			[JsonProperty("rarity")]
			public long Rarity { get; set; }

			[JsonProperty("expires_in")]
			public object ExpiresIn { get; set; }

			[JsonProperty("short_name", NullValueHandling = NullValueHandling.Ignore)]
			public string ShortName { get; set; }

			[JsonProperty("bonuses", NullValueHandling = NullValueHandling.Ignore)]
			public Dictionary<string, long> Bonuses { get; set; }

			[JsonProperty("time_modifier", NullValueHandling = NullValueHandling.Ignore)]
			public long? TimeModifier { get; set; }

			[JsonProperty("cr_modifier", NullValueHandling = NullValueHandling.Ignore)]
			public long? CrModifier { get; set; }

			[JsonProperty("reward_modifier", NullValueHandling = NullValueHandling.Ignore)]
			public long? RewardModifier { get; set; }

			[JsonProperty("crafting_bonuses", NullValueHandling = NullValueHandling.Ignore)]
			public Dictionary<string, double> CraftingBonuses { get; set; }
		}
	}
