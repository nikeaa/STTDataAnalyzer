using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class EventLeaderboard
	{

		[JsonProperty("instance_id")]
		public int InstanceId { get; set; }

		[JsonProperty("leaderboard")]
		public EventLeaderboardEntry[] Leaderboard { get; set; }
	}
}
