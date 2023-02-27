using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class SmallBonus
	{
		[JsonProperty("traits")]
		public string[] Traits { get; set; }

	}
}