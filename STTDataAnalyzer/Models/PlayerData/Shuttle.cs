using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdShuttle
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("state")]
		public long State { get; set; }

		[JsonProperty("expires_in")]
		public string ExpiresInString { get; set; }

		public double ExpiresIn
		{
			get
			{
				return (!string.IsNullOrEmpty(ExpiresInString)) ? double.Parse(ExpiresInString) : 0;
			}
		}

		[JsonProperty("faction_id")]
		public long FactionId { get; set; }

		[JsonProperty("slots")]
		public List<PdSlot> Slots { get; set; }

		[JsonProperty("rewards")]
		public List<ShuttleTokenPreviewItem> Rewards { get; set; }

		[JsonProperty("is_rental")]
		public bool IsRental { get; set; }
	}
}
