using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class JackpotReward
	{

		[JsonProperty("type")]
		public int Type { get; set; }

		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("item_type")]
		public int ItemType { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("full_name")]
		public string FullName { get; set; }

		[JsonProperty("flavor")]
		public string Flavor { get; set; }

		[JsonProperty("icon")]
		public Icon Icon { get; set; }

		[JsonProperty("quantity")]
		public int Quantity { get; set; }

		[JsonProperty("rarity")]
		public int Rarity { get; set; }
	}
}