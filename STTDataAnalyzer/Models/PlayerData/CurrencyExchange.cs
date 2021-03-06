using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdCurrencyExchange
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("amount")]
		public long Amount { get; set; }

		[JsonProperty("output")]
		public long Output { get; set; }

		[JsonProperty("input")]
		public long Input { get; set; }

		[JsonProperty("schedule")]
		public List<long> Schedule { get; set; }

		[JsonProperty("exchanges_today")]
		public long ExchangesToday { get; set; }

		[JsonProperty("bonus", NullValueHandling = NullValueHandling.Ignore)]
		public long? Bonus { get; set; }

		[JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
		public long? Limit { get; set; }
	}
}
