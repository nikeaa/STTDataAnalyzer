using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdRecipe
	{
		[JsonProperty("demands")]
		public List<PdDemand> Demands { get; set; }

		[JsonProperty("validity_hash")]
		public string ValidityHash { get; set; }
	}
}
