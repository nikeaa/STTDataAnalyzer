using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdCwin
	{
		[JsonProperty("open")]
		public long Open { get; set; }

		[JsonProperty("close")]
		public long Close { get; set; }
	}
}
