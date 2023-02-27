using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class Icon
	{
		[JsonProperty("file")]
		public string File { get; set; }
	}
}
