using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdFaction
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("reputation")]
		public long Reputation { get; set; }

		[JsonProperty("discovered")]
		public long Discovered { get; set; }

		[JsonProperty("completed_shuttle_adventures")]
		public long CompletedShuttleAdventures { get; set; }

		[JsonProperty("icon")]
		public PdIconClass Icon { get; set; }

		[JsonProperty("representative_icon")]
		public PdIconClass RepresentativeIcon { get; set; }

		[JsonProperty("representative_full_body")]
		public PdIconClass RepresentativeFullBody { get; set; }

		[JsonProperty("reputation_icon")]
		public PdIconClass ReputationIcon { get; set; }

		[JsonProperty("reputation_item_icon")]
		public PdIconClass ReputationItemIcon { get; set; }

		[JsonProperty("home_system")]
		public string HomeSystem { get; set; }

		[JsonProperty("shop_layout")]
		public string ShopLayout { get; set; }

		[JsonProperty("shuttle_token_id")]
		public long ShuttleTokenId { get; set; }

		[JsonProperty("shuttle_token_preview_item")]
		public ShuttleTokenPreviewItem ShuttleTokenPreviewItem { get; set; }

		[JsonProperty("event_winner_rewards")]
		public List<object> EventWinnerRewards { get; set; }

		[JsonProperty("shuttle_mission_rewards")]
		public List<PdShuttleMissionReward> ShuttleMissionRewards { get; set; }
	}
}
