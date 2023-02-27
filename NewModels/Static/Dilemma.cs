using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class Dilemma
	{
		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("choiceA")]
		public DilemmaChoice ChoiceA { get; set; }

		[JsonProperty("choiceB")]
		public DilemmaChoice ChoiceB { get; set; }

		[JsonProperty("choiceC")]
		public DilemmaChoice ChoiceC { get; set; }
	}
}