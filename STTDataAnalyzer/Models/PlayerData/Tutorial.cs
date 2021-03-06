using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
	{
		public partial class PdTutorial
		{
			[JsonProperty("id")]
			public long Id { get; set; }

			[JsonProperty("symbol")]
			public string Symbol { get; set; }

			[JsonProperty("state")]
			public PdTutorialState State { get; set; }
		}
	}
