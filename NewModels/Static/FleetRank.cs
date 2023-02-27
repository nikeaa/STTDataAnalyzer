using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class FleetRank
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("fleet_rank")]
		public int Rank { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}
}