﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class Environment
	{
		[JsonProperty("tutorials")]
		public List<string> Tutorials { get; set; }

		[JsonProperty("level_requirement_123s")]
		public long LevelRequirement123S { get; set; }

		[JsonProperty("restrictions")]
		public object Restrictions { get; set; }

		[JsonProperty("flags")]
		public List<string> Flags { get; set; }

		[JsonProperty("background_idle_period")]
		public long BackgroundIdlePeriod { get; set; }

		[JsonProperty("hud_special_offer_poll_frequency")]
		public long HudSpecialOfferPollFrequency { get; set; }

		[JsonProperty("pvp_enabled")]
		public bool PvpEnabled { get; set; }

		[JsonProperty("stasis_vault_enabled")]
		public bool StasisVaultEnabled { get; set; }

		[JsonProperty("fleet_request_purge_threshold")]
		public long FleetRequestPurgeThreshold { get; set; }

		[JsonProperty("fleet_request_purge_expiration_days")]
		public long FleetRequestPurgeExpirationDays { get; set; }

		[JsonProperty("event_refresh_min_seconds")]
		public long EventRefreshMinSeconds { get; set; }

		[JsonProperty("event_refresh_max_seconds")]
		public long EventRefreshMaxSeconds { get; set; }

		[JsonProperty("squadrons_enabled")]
		public bool SquadronsEnabled { get; set; }

		[JsonProperty("honor_enabled")]
		public bool HonorEnabled { get; set; }

		[JsonProperty("force_offer_popup_at_login")]
		public bool ForceOfferPopupAtLogin { get; set; }

		[JsonProperty("adaptive_offers_enabled")]
		public bool AdaptiveOffersEnabled { get; set; }

		[JsonProperty("buy_back_enabled")]
		public bool BuyBackEnabled { get; set; }

		[JsonProperty("allow_webgl_looping_audio")]
		public bool AllowWebglLoopingAudio { get; set; }

		[JsonProperty("display_server_environment")]
		public bool DisplayServerEnvironment { get; set; }

		[JsonProperty("video_ad_campaign_limit")]
		public PdVideoAdCampaignLimit VideoAdCampaignLimit { get; set; }

		[JsonProperty("shuttle_rework_enabled")]
		public bool ShuttleReworkEnabled { get; set; }

		[JsonProperty("shuttle_rental_dil_cost")]
		public long ShuttleRentalDilCost { get; set; }

		[JsonProperty("gauntlet_enabled")]
		public bool GauntletEnabled { get; set; }

		[JsonProperty("location_updates_enabled")]
		public bool LocationUpdatesEnabled { get; set; }

		[JsonProperty("location_chat_enabled")]
		public bool LocationChatEnabled { get; set; }

		[JsonProperty("faction_event_order_randomized")]
		public bool FactionEventOrderRandomized { get; set; }

		[JsonProperty("fleet_activities_enabled")]
		public bool FleetActivitiesEnabled { get; set; }

		[JsonProperty("fleet_activities_restriction_enabled")]
		public bool FleetActivitiesRestrictionEnabled { get; set; }

		[JsonProperty("enable_server_toasts")]
		public bool EnableServerToasts { get; set; }

		[JsonProperty("minimum_toast_delay_in_seconds")]
		public long MinimumToastDelayInSeconds { get; set; }

		[JsonProperty("starbase_enabled")]
		public bool StarbaseEnabled { get; set; }

		[JsonProperty("voyages_enabled")]
		public bool VoyagesEnabled { get; set; }

		[JsonProperty("starbase_refresh")]
		public long StarbaseRefresh { get; set; }

		[JsonProperty("collections_enabled")]
		public bool CollectionsEnabled { get; set; }

		[JsonProperty("detect_conflict_mastery_errors")]
		public bool DetectConflictMasteryErrors { get; set; }

		[JsonProperty("reroll_enabled")]
		public bool RerollEnabled { get; set; }

		[JsonProperty("reroll_rarity_limit")]
		public long RerollRarityLimit { get; set; }

		[JsonProperty("dilithium_purchase_popup_enabled")]
		public bool DilithiumPurchasePopupEnabled { get; set; }

		[JsonProperty("dilithium_purchase_popup_threshold")]
		public long DilithiumPurchasePopupThreshold { get; set; }

		[JsonProperty("lazy_load_ui")]
		public bool LazyLoadUi { get; set; }

		[JsonProperty("help_center_button_enabled")]
		public bool HelpCenterButtonEnabled { get; set; }

		[JsonProperty("one_tap_craft_enabled")]
		public bool OneTapCraftEnabled { get; set; }

		[JsonProperty("anti_macro")]
		public PdAntiMacro AntiMacro { get; set; }

		[JsonProperty("dismiss_crew_from_iteminfopanel")]
		public bool DismissCrewFromIteminfopanel { get; set; }

		[JsonProperty("dismiss_all_crew_from_purchaseresultspanel")]
		public bool DismissAllCrewFromPurchaseresultspanel { get; set; }

		[JsonProperty("use_updated_speed_up_cost")]
		public bool UseUpdatedSpeedUpCost { get; set; }

		[JsonProperty("rental_shuttles_enabled")]
		public bool RentalShuttlesEnabled { get; set; }

		[JsonProperty("use_v2_activities_panel")]
		public bool UseV2ActivitiesPanel { get; set; }

		[JsonProperty("seasons_enabled")]
		public bool SeasonsEnabled { get; set; }

		[JsonProperty("load_with_equipment_rank_caching")]
		public bool LoadWithEquipmentRankCaching { get; set; }

		[JsonProperty("currency_gained_analytic_enabled")]
		public bool CurrencyGainedAnalyticEnabled { get; set; }

		[JsonProperty("fix_chroniton_ad_boost")]
		public bool FixChronitonAdBoost { get; set; }

		[JsonProperty("season_123_tier_threshold")]
		public long Season123_TierThreshold { get; set; }

		[JsonProperty("season_123_no_premium_tier_threshold")]
		public long Season123_NoPremiumTierThreshold { get; set; }

		[JsonProperty("grant_current_season_entitlement")]
		public bool GrantCurrentSeasonEntitlement { get; set; }
	}
}
