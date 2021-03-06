using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdShuttleAdventure
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("faction_id")]
		public long FactionId { get; set; }

		[JsonProperty("token_archetype_id")]
		public object TokenArchetypeId { get; set; }

		[JsonProperty("challenge_rating")]
		public long ChallengeRating { get; set; }

		[JsonProperty("shuttles")]
		public List<PdShuttle> Shuttles { get; set; }

		[JsonProperty("completes_in_seconds")]
		public long CompletesInSeconds { get; set; }

		[JsonProperty("x")]
		public long X { get; set; }

		[JsonProperty("y")]
		public long Y { get; set; }
	}
}
