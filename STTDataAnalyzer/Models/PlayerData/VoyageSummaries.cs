using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdVoyageSummaries
	{
		[JsonProperty("summaries")]
		public List<PdSummary> Summaries { get; set; }

		[JsonProperty("flavor_amount")]
		public long FlavorAmount { get; set; }
	}
}
