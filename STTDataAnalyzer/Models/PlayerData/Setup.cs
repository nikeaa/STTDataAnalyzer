using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdSetup
	{
		[JsonProperty("ship_id")]
		public long ShipId { get; set; }

		[JsonProperty("slots")]
		public List<long> Slots { get; set; }
	}
}
