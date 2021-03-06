using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdEntitlements
	{
		[JsonProperty("granted")]
		public List<PdGranted> Granted { get; set; }

		[JsonProperty("claimed")]
		public List<Claimed> Claimed { get; set; }
	}
}
