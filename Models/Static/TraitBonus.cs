using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class TraitBonus
	{
		[JsonProperty("trait")]
		public string Trait { get; set; }

		[JsonProperty("bonuses")]
		public int[] Bonuses { get; set; }
	}
}