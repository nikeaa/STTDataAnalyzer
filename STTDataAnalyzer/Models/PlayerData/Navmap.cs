using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdNavmap
	{
		[JsonProperty("places")]
		public List<Place> Places { get; set; }

		[JsonProperty("systems")]
		public List<SystemElement> Systems { get; set; }
	}
}
