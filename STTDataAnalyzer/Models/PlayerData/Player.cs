using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdPlayer
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("dbid")]
		public long Dbid { get; set; }

		[JsonProperty("lang")]
		public string Lang { get; set; }

		[JsonProperty("timezone")]
		public string Timezone { get; set; }

		[JsonProperty("locale")]
		public string Locale { get; set; }

		[JsonProperty("display_name")]
		public string DisplayName { get; set; }

		[JsonProperty("money")]
		public long Money { get; set; }

		[JsonProperty("premium_purchasable")]
		public long PremiumPurchasable { get; set; }

		[JsonProperty("premium_earnable")]
		public long PremiumEarnable { get; set; }

		[JsonProperty("honor")]
		public long Honor { get; set; }

		[JsonProperty("shuttle_rental_tokens")]
		public long ShuttleRentalTokens { get; set; }

		[JsonProperty("vip_points")]
		public long VipPoints { get; set; }

		[JsonProperty("vip_level")]
		public long VipLevel { get; set; }

		[JsonProperty("currency_exchanges")]
		public List<PdCurrencyExchange> CurrencyExchanges { get; set; }

		[JsonProperty("replicator_uses_today")]
		public long ReplicatorUsesToday { get; set; }

		[JsonProperty("replicator_limit")]
		public long ReplicatorLimit { get; set; }

		[JsonProperty("character")]
		public PdCharacter Character { get; set; }

		[JsonProperty("fleet")]
		public PdFleet Fleet { get; set; }

		[JsonProperty("squad")]
		public PdSquad Squad { get; set; }

		[JsonProperty("mailbox")]
		public PdMailbox Mailbox { get; set; }

		[JsonProperty("fleet_invite")]
		public PdFleetInvite FleetInvite { get; set; }

		[JsonProperty("entitlements")]
		public PdEntitlements Entitlements { get; set; }

		[JsonProperty("chats")]
		public PdChats Chats { get; set; }

		[JsonProperty("commerce")]
		public PdChats Commerce { get; set; }

		[JsonProperty("environment")]
		public Environment Environment { get; set; }

		[JsonProperty("motd")]
		public PdMotd Motd { get; set; }

		[JsonProperty("npe_complete")]
		public bool NpeComplete { get; set; }

		[JsonProperty("community_links")]
		public List<CommunityLink> CommunityLinks { get; set; }
	}
}
