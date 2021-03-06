using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdAntiMacro
	{
		[JsonProperty("min_minutes_to_popup")]
		public long MinMinutesToPopup { get; set; }

		[JsonProperty("variable_minutes_to_popup")]
		public long VariableMinutesToPopup { get; set; }
	}
}
