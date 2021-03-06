using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdSlot
	{
		[JsonProperty("level")]
		public object Level { get; set; }

		[JsonProperty("required_trait")]
		public object RequiredTrait { get; set; }

		[JsonProperty("skills")]
		public List<string> Skills { get; set; }

		[JsonProperty("trait_bonuses")]
		public PdChats TraitBonuses { get; set; }
	}
}
