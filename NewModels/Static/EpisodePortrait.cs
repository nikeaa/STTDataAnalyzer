using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class EpisodePortrait
	{
		[JsonProperty("file")]
		public string File { get; set; }
	}
}