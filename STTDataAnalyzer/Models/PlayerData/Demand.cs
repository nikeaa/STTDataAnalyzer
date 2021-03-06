using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
	{
		public partial class PdDemand
		{
			[JsonProperty("archetype_id")]
			public long ArchetypeId { get; set; }

			[JsonProperty("count")]
			public long Count { get; set; }
		}
	}
