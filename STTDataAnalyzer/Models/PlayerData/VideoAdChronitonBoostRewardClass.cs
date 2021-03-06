using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdVideoAdChronitonBoostRewardClass
	{
		[JsonProperty("type")]
		public long Type { get; set; }

		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("symbol")]
		public PdVideoAdChronitonBoostRewardSymbol Symbol { get; set; }

		[JsonProperty("name")]
		public PdFullNameEnum Name { get; set; }

		[JsonProperty("full_name")]
		public PdFullNameEnum FullName { get; set; }

		[JsonProperty("flavor")]
		public string Flavor { get; set; }

		[JsonProperty("icon")]
		public PdIcon Icon { get; set; }

		[JsonProperty("quantity")]
		public long Quantity { get; set; }

		[JsonProperty("rarity")]
		public long Rarity { get; set; }
	}
}
