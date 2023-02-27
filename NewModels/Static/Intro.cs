using Newtonsoft.Json;


namespace STTDataAnalyzer.Models.Static
{
	public class Intro
	{
		[JsonProperty("text")]
		public string Text { get; set; }

		[JsonProperty("portrait")]
		public Icon Portrait { get; set; }

		[JsonProperty("speaker_name")]
		public string SpeakerName { get; set; }

		[JsonProperty("response")]
		public string Response { get; set; }
	}
}