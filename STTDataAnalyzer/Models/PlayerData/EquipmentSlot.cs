namespace STTDataAnalyzer.Models.PlayerData
{
	using Newtonsoft.Json;

	public partial class PdEquipmentSlot
	{
		[JsonProperty("level")]
		public long Level { get; set; }

		[JsonProperty("archetype")]
		public long Archetype { get; set; }
	}
}
