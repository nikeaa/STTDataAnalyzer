using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdSquad
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("rank")]
		public string Rank { get; set; }
	}
}
