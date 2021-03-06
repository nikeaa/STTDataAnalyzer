using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
	{
		public partial class PdBoostWindow
		{
			[JsonProperty("window")]
			public List<long> Window { get; set; }

			[JsonProperty("reward")]
			public PdVideoAdChronitonBoostRewardClass Reward { get; set; }
		}
	}
