using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdRewardShip
	{
		[JsonProperty("type")]
		public long Type { get; set; }

		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("full_name")]
		public string FullName { get; set; }

		[JsonProperty("flavor")]
		public string Flavor { get; set; }

		[JsonProperty("icon")]
		public PdIconClass Icon { get; set; }

		[JsonProperty("shields")]
		public long Shields { get; set; }

		[JsonProperty("hull")]
		public long Hull { get; set; }

		[JsonProperty("attack")]
		public long Attack { get; set; }

		[JsonProperty("evasion")]
		public long Evasion { get; set; }

		[JsonProperty("accuracy")]
		public long Accuracy { get; set; }

		[JsonProperty("quantity")]
		public long Quantity { get; set; }

		[JsonProperty("rarity")]
		public long Rarity { get; set; }
	}
}
