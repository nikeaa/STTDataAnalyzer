using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdCharacter
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("display_name")]
		public string DisplayName { get; set; }

		[JsonProperty("using_default_name")]
		public bool UsingDefaultName { get; set; }

		[JsonProperty("level")]
		public long Level { get; set; }

		[JsonProperty("max_level")]
		public long MaxLevel { get; set; }

		[JsonProperty("xp")]
		public long Xp { get; set; }

		[JsonProperty("xp_for_current_level")]
		public long XpForCurrentLevel { get; set; }

		[JsonProperty("xp_for_next_level")]
		public long XpForNextLevel { get; set; }

		[JsonProperty("location")]
		public PdAtion Location { get; set; }

		[JsonProperty("destination")]
		public PdAtion Destination { get; set; }

		[JsonProperty("navmap")]
		public PdNavmap Navmap { get; set; }

		[JsonProperty("accepted_missions")]
		public List<PdAcceptedMission> AcceptedMissions { get; set; }

		[JsonProperty("active_conflict")]
		public object ActiveConflict { get; set; }

		[JsonProperty("shuttle_bays")]
		public long ShuttleBays { get; set; }

		[JsonProperty("next_shuttle_bay_cost")]
		public object NextShuttleBayCost { get; set; }

		[JsonProperty("can_purchase_shuttle_bay")]
		public bool CanPurchaseShuttleBay { get; set; }

		[JsonProperty("crew_avatar")]
		public PdCrewAvatar CrewAvatar { get; set; }

		[JsonProperty("stored_immortals")]
		public List<PdStoredImmortal> StoredImmortals { get; set; }

		[JsonProperty("seconds_to_scan_cooldown")]
		public long SecondsToScanCooldown { get; set; }

		[JsonProperty("scan_speedups_today")]
		public long ScanSpeedupsToday { get; set; }

		[JsonProperty("replay_energy_max")]
		public long ReplayEnergyMax { get; set; }

		[JsonProperty("replay_energy_rate")]
		public long ReplayEnergyRate { get; set; }

		[JsonProperty("seconds_from_replay_energy_basis")]
		public long SecondsFromReplayEnergyBasis { get; set; }

		[JsonProperty("replay_energy_overflow")]
		public long ReplayEnergyOverflow { get; set; }

		[JsonProperty("boost_windows")]
		public List<PdBoostWindow> BoostWindows { get; set; }

		[JsonProperty("seconds_from_last_boost_claim")]
		public double SecondsFromLastBoostClaim { get; set; }

		[JsonProperty("video_ad_chroniton_boost_reward")]
		public PdVideoAdChronitonBoostRewardClass VideoAdChronitonBoostReward { get; set; }

		[JsonProperty("cadet_tickets")]
		public Tickets CadetTickets { get; set; }

		[JsonProperty("pvp_tickets")]
		public Tickets PvpTickets { get; set; }

		[JsonProperty("event_tickets")]
		public Tickets EventTickets { get; set; }

		[JsonProperty("cadet_schedule")]
		public PdCadetSchedule CadetSchedule { get; set; }

		[JsonProperty("pvp_divisions")]
		public List<PdPvpDivision> PvpDivisions { get; set; }

		[JsonProperty("pvp_timer")]
		public PdPvpTimer PvpTimer { get; set; }

		[JsonProperty("crew")]
		public List<PdCrew> Crew { get; set; }

		[JsonProperty("items")]
		public List<PdItem> Items { get; set; }

		[JsonProperty("crew_borrows")]
		public List<object> CrewBorrows { get; set; }

		[JsonProperty("crew_shares")]
		public List<object> CrewShares { get; set; }

		[JsonProperty("crew_limit")]
		public long CrewLimit { get; set; }

		[JsonProperty("crew_limit_increase_per_purchase")]
		public long CrewLimitIncreasePerPurchase { get; set; }

		[JsonProperty("next_crew_limit_increase_cost")]
		public PdNextCrewLimitIncreaseCost NextCrewLimitIncreaseCost { get; set; }

		[JsonProperty("can_purchase_crew_limit_increase")]
		public bool CanPurchaseCrewLimitIncrease { get; set; }

		[JsonProperty("item_limit")]
		public long ItemLimit { get; set; }

		[JsonProperty("ships")]
		public List<ShipElement> Ships { get; set; }

		[JsonProperty("current_ship_id")]
		public long CurrentShipId { get; set; }

		[JsonProperty("shuttle_adventures")]
		public List<PdShuttleAdventure> ShuttleAdventures { get; set; }

		[JsonProperty("factions")]
		public List<PdFaction> Factions { get; set; }

		[JsonProperty("disputes")]
		public List<object> Disputes { get; set; }

		[JsonProperty("tng_the_game_level")]
		public long TngTheGameLevel { get; set; }

		[JsonProperty("open_packs")]
		public List<object> OpenPacks { get; set; }

		[JsonProperty("daily_activities")]
		public List<DailyActivity> DailyActivities { get; set; }

		[JsonProperty("next_daily_activity_reset")]
		public double NextDailyActivityReset { get; set; }

		[JsonProperty("next_starbase_donation_reset")]
		public double NextStarbaseDonationReset { get; set; }

		[JsonProperty("fleet_activities")]
		public List<PdFleetActivity> FleetActivities { get; set; }

		[JsonProperty("next_fleet_activity_reset")]
		public double NextFleetActivityReset { get; set; }

		[JsonProperty("freestanding_quests")]
		public List<object> FreestandingQuests { get; set; }

		[JsonProperty("daily_rewards_state")]
		public PdDailyRewardsState DailyRewardsState { get; set; }

		[JsonProperty("dispute_histories")]
		public List<PdDisputeHistory> DisputeHistories { get; set; }

		[JsonProperty("stimpack")]
		public object Stimpack { get; set; }

		[JsonProperty("tutorials")]
		public List<PdTutorial> Tutorials { get; set; }

		[JsonProperty("location_channel_prefix")]
		public string LocationChannelPrefix { get; set; }

		[JsonProperty("honor_reward_by_rarity")]
		public List<long> HonorRewardByRarity { get; set; }

		[JsonProperty("voyage_descriptions")]
		public List<VoyageDescription> VoyageDescriptions { get; set; }

		[JsonProperty("voyage")]
		public List<object> Voyage { get; set; }

		[JsonProperty("voyage_summaries")]
		public PdVoyageSummaries VoyageSummaries { get; set; }

		[JsonProperty("cryo_collections")]
		public List<PdCryoCollection> CryoCollections { get; set; }

		[JsonProperty("reroll_descriptions")]
		public List<PdRerollDescription> RerollDescriptions { get; set; }

		[JsonProperty("crew_collection_buffs")]
		public List<PdBuff> CrewCollectionBuffs { get; set; }

		[JsonProperty("starbase_buffs")]
		public List<PdBuff> StarbaseBuffs { get; set; }

		[JsonProperty("all_buffs")]
		public List<PdBuff> AllBuffs { get; set; }

		public Dictionary<string, (double, double, double)> GetBuffs()
		{
			return new Dictionary<string, (double Core, double Min, double Max)>
				{
					{ "commandSkill", getBuffs("command") },
					{ "diplomacySkill", getBuffs("diplomacy") },
					{ "engineeringSkill", getBuffs("engineering") },
					{ "medicineSkill", getBuffs("medicine") },
					{ "scienceSkill", getBuffs("science") },
					{ "securitySkill", getBuffs("security") }
				};
		}

		private (double Core, double Min, double Max) getBuffs(string skillName)
		{
			double coreBuff = AllBuffs.Where(ab => ab.Stat == skillName + "_skill_core").Select(ab => ab.Value).FirstOrDefault();
			double rangeMaxBuff = AllBuffs.Where(ab => ab.Stat == skillName + "_skill_range_max").Select(ab => ab.Value).FirstOrDefault();
			double rangeMinBuff = AllBuffs.Where(ab => ab.Stat == skillName + "_skill_range_min").Select(ab => ab.Value).FirstOrDefault();

			return (coreBuff, rangeMaxBuff, rangeMinBuff);
		}
	}
}
