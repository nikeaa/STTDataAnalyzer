using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class EquipmentSlot
	{
		[JsonProperty("level")]
		public int Level { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }
	}
}