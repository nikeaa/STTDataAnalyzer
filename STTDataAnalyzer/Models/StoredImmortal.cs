namespace STTDataAnalyzer
{
	namespace SttUser
	{
		using Newtonsoft.Json;

		public partial class StoredImmortal
		{
			[JsonProperty("id")]
			public long Id { get; set; }

			[JsonProperty("quantity")]
			public long Quantity { get; set; }
		}
	}
}
