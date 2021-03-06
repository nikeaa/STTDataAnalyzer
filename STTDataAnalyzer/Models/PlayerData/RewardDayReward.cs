using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdRewardDayReward
	{
		[JsonProperty("type")]
		public long Type { get; set; }

		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("rarity")]
		public long Rarity { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("full_name")]
		public string FullName { get; set; }

		[JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
		public string Flavor { get; set; }

		[JsonProperty("icon")]
		public PdIcon Icon { get; set; }

		[JsonProperty("quantity")]
		public long Quantity { get; set; }

		[JsonProperty("portrait", NullValueHandling = NullValueHandling.Ignore)]
		public PdIconClass Portrait { get; set; }

		[JsonProperty("full_body", NullValueHandling = NullValueHandling.Ignore)]
		public PdIconClass FullBody { get; set; }

		[JsonProperty("skills", NullValueHandling = NullValueHandling.Ignore)]
		public PdRewardSkills Skills { get; set; }

		[JsonProperty("traits", NullValueHandling = NullValueHandling.Ignore)]
		public List<string> Traits { get; set; }

		[JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
		public PdCrewAction Action { get; set; }

		[JsonProperty("ship", NullValueHandling = NullValueHandling.Ignore)]
		public PdRewardShip Ship { get; set; }

		[JsonProperty("item_type", NullValueHandling = NullValueHandling.Ignore)]
		public long? ItemType { get; set; }
	}
}
