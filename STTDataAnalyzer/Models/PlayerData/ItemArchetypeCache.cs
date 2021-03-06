using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdItemArchetypeCache
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("archetypes")]
		public List<PdArchetype> Archetypes { get; set; }
	}
}
