using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
	{
		public partial class PdCapAchiever
		{
			[JsonProperty("name")]
			public string Name { get; set; }

			[JsonProperty("date")]
			public long Date { get; set; }
		}
	}
