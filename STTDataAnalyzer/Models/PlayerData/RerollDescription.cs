using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
	{
		public partial class PdRerollDescription
		{
			[JsonProperty("id")]
			public long Id { get; set; }

			[JsonProperty("jackpot")]
			public long Jackpot { get; set; }

			[JsonProperty("crew_required")]
			public long CrewRequired { get; set; }
		}
	}
