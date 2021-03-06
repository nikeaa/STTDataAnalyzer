using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class Tickets
	{
		[JsonProperty("current")]
		public long Current { get; set; }

		[JsonProperty("max")]
		public long Max { get; set; }

		[JsonProperty("spend_in")]
		public double SpendIn { get; set; }

		[JsonProperty("reset_in")]
		public double ResetIn { get; set; }
	}
}
