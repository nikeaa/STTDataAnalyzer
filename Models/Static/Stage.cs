using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class Stage
	{
		[JsonProperty("grid_x")]
		public int GridX { get; set; }

		[JsonProperty("text")]
		public string Text { get; set; }
	}
}