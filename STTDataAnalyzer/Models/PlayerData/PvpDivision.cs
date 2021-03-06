using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdPvpDivision
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("tier")]
		public long Tier { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("min_ship_rarity")]
		public long MinShipRarity { get; set; }

		[JsonProperty("max_ship_rarity")]
		public long MaxShipRarity { get; set; }

		[JsonProperty("max_crew_rarity")]
		public long MaxCrewRarity { get; set; }

		[JsonProperty("setup")]
		public PdSetup Setup { get; set; }
	}
}
