namespace STTDataAnalyzer
{
	namespace SttUser
	{
		using Newtonsoft.Json;
		using System.Collections.Generic;

		public partial class Crew
		{
			[JsonProperty("id")]
			public long Id { get; set; }

			[JsonProperty("symbol")]
			public string Symbol { get; set; }

			[JsonProperty("name")]
			public string Name { get; set; }

			[JsonProperty("short_name")]
			public string ShortName { get; set; }

			[JsonProperty("flavor")]
			public string Flavor { get; set; }

			[JsonProperty("archetype_id")]
			public long ArchetypeId { get; set; }

			[JsonProperty("xp")]
			public long Xp { get; set; }

			[JsonProperty("xp_for_current_level")]
			public long XpForCurrentLevel { get; set; }

			[JsonProperty("xp_for_next_level")]
			public long XpForNextLevel { get; set; }

			[JsonProperty("max_xp")]
			public long MaxXp { get; set; }

			[JsonProperty("favorite")]
			public bool Favorite { get; set; }

			[JsonProperty("level")]
			public long Level { get; set; }

			[JsonProperty("in_buy_back_state")]
			public bool InBuyBackState { get; set; }

			[JsonProperty("max_level")]
			public long MaxLevel { get; set; }

			[JsonProperty("rarity")]
			public long Rarity { get; set; }

			[JsonProperty("max_rarity")]
			public long MaxRarity { get; set; }

			[JsonProperty("equipment_rank")]
			public long EquipmentRank { get; set; }

			[JsonProperty("max_equipment_rank")]
			public long MaxEquipmentRank { get; set; }

			[JsonProperty("equipment_slots")]
			public List<EquipmentSlot> EquipmentSlots { get; set; }

			[JsonProperty("equipment")]
			public List<List<long>> Equipment { get; set; }

			[JsonProperty("icon")]
			public IconClass Icon { get; set; }

			[JsonProperty("portrait")]
			public IconClass Portrait { get; set; }

			[JsonProperty("full_body")]
			public IconClass FullBody { get; set; }

			[JsonProperty("voice_over")]
			public string VoiceOver { get; set; }

			[JsonProperty("expires_in")]
			public double? ExpiresIn { get; set; }

			[JsonProperty("active_status")]
			public long ActiveStatus { get; set; }

			[JsonProperty("active_id")]
			public long? ActiveId { get; set; }

			[JsonProperty("active_index")]
			public long ActiveIndex { get; set; }

			[JsonProperty("passive_status")]
			public long PassiveStatus { get; set; }

			[JsonProperty("passive_id")]
			public long? PassiveId { get; set; }

			[JsonProperty("passive_index")]
			public long PassiveIndex { get; set; }

			[JsonProperty("traits")]
			public List<string> Traits { get; set; }

			[JsonProperty("traits_hidden")]
			public List<string> TraitsHidden { get; set; }

			[JsonProperty("skills")]
			public BaseSkillsClass Skills { get; set; }

			[JsonProperty("base_skills")]
			public BaseSkillsClass BaseSkills { get; set; }

			[JsonProperty("ship_battle")]
			public ShipBattle ShipBattle { get; set; }

			[JsonProperty("action")]
			public CrewAction Action { get; set; }

			[JsonProperty("default_avatar")]
			public bool DefaultAvatar { get; set; }

			[JsonProperty("cross_fuse_targets")]
			public List<string> CrossFuseTargets { get; set; }

			[JsonProperty("cap_achiever")]
			public CapAchiever CapAchiever { get; set; }
		}
	}
}
