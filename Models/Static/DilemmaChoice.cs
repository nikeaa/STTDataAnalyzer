using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class DilemmaChoice
	{
		[JsonProperty("text")]
		public string Text{ get; set; }

		[JsonProperty("reward")]
		public string[] Reward { get; set; }
	}
}