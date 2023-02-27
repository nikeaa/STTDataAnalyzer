using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class Progress
	{

		[JsonProperty("goal_progress")]
		public int GoalProgress { get; set; }

		[JsonProperty("goals")]
		public int Goals { get; set; }
	}
}