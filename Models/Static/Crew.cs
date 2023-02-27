using System;
using System.Collections.Generic;
using STTDataAnalyzer.Models.Converters;
using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class Crew
	{
		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("short_name")]
		public string ShortName { get; set; }

		[JsonProperty("flavor")]
		public string Flavor { get; set; }

		[JsonProperty("archetype_id")]
		public int ArchetypeId { get; set; }

		[JsonProperty("max_rarity")]
		public int MaxRarity { get; set; }

		[JsonProperty("equipment_slots")]
		public EquipmentSlot[] EquipmentSlots { get; set; }

		[JsonProperty("voice_over")]
		public string VoiceOver { get; set; }

		[JsonProperty("traits")]
		public string[] Traits { get; set; }

		[JsonProperty("traits_hidden")]
		public string[] TraitsHidden { get; set; }

		[JsonProperty("base_skills")]
		[JsonConverter(typeof(BaseSkillsConverter))]
		public List<Skill> BaseSkills { get; set; }

		[JsonProperty("ship_battle")]
		public ShipBattle ShipBattle { get; set; }

		[JsonProperty("action")]
		public Action Action { get; set; }

		[JsonProperty("cross_fuse_targets")]
		[JsonConverter(typeof(SingleValueArrayConverter<CrossFuseTarget>))]
		public List<CrossFuseTarget> CrossFuseTargets { get; set; }

		[JsonProperty("skill_data")]
		[JsonConverter(typeof(SkillDataConverter))]
		public List<Skill>[] SkillData { get; set; }

		[JsonProperty("intermediate_skill_data")]
		public IntermediateSkillData[] IntermediateSkillData;

		[JsonProperty("is_craftable")]
		public bool IsCraftable { get; set; }

		[JsonProperty("imageUrlPortrait")]
		public string ImageUrlPortrait { get; set; }

		[JsonProperty("imageUrlFullBody")]
		public string ImageUrlFullBody { get; set; }

		[JsonProperty("series")]
		public string Series { get; set; }

		[JsonProperty("traits_names")]
		public string[] TraitsNames { get; set; }

		[JsonProperty("collections")]
		public string[] Collections { get; set; }

		[JsonProperty("totalChronCost")]
		public int TotalChronCost { get; set; }

		[JsonProperty("factionOnlyTotal")]
		public int FactionOnlyTotal { get; set; }

		[JsonProperty("craftCost")]
		public int CraftCost { get; set; }

		[JsonProperty("ranks")]
		[JsonConverter(typeof(RanksConverter))]
		public Ranks Ranks { get; set; }

		[JsonProperty("bigbook_tier")]
		public int BigbookTier { get; set; }

		[JsonProperty("events")]
		public int Events { get; set; }

		[JsonProperty("in_portal")]
		public bool InPortal { get; set; }

		[JsonProperty("date_added")]
		public DateTime DateAdded { get; set; }

		[JsonProperty("obtained")]
		public string Obtained { get; set; }

		[JsonProperty("markdownContent")]
		public string MarkdownContent { get; set; }

		[JsonProperty("unique_polestar_combos")]
		public string[][] UniquePolestarCombos { get; set; }
	}
}
