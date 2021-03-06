using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class VoyageDescription
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("icon")]
		public string Icon { get; set; }

		[JsonProperty("skills")]
		public VoyageDescriptionSkills Skills { get; set; }

		[JsonProperty("ship_trait")]
		public string ShipTrait { get; set; }

		[JsonProperty("crew_slots")]
		public List<PdCrewSlot> CrewSlots { get; set; }

		[JsonProperty("potential_rewards")]
		public List<PotentialReward> PotentialRewards { get; set; }
	}
}
