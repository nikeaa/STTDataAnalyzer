using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class Lock
	{
		[JsonProperty("success_on_node_id")]
		public int SuccessOnNodeId { get; set; }

		[JsonProperty("trait")]
		public string Trait { get; set; }
	}
}