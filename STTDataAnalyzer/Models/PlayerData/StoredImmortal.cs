using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdStoredImmortal
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("quantity")]
		public long Quantity { get; set; }
	}
}
