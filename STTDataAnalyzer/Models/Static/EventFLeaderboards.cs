using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class EventFLeaderboard
	{
		[JsonProperty("fixed_instance_id")]
		public int FixedInstanceId { get; set; }

		[JsonProperty("fleet_ranks")]
		public FleetRank[] FleetRanks { get; set; }
	}
}
