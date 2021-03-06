using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdGranted
	{
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("gamerTag")]
		public long GamerTag { get; set; }

		[JsonProperty("symbol")]
		public PdGrantedSymbol Symbol { get; set; }

		[JsonProperty("state")]
		public PdFromEnum State { get; set; }

		[JsonProperty("updated")]
		public long Updated { get; set; }

		[JsonProperty("history")]
		public List<PdGrantedHistory> History { get; set; }

		[JsonProperty("specialized", NullValueHandling = NullValueHandling.Ignore)]
		public PdSpecialized? Specialized { get; set; }
	}
}
