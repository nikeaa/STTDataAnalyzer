using System.Collections.Generic;
using STTDataAnalyzer.Converters;
using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
    public class BotCrew
    {
        [JsonProperty("archetype_id")]
        public int ArchetypeId { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("short_name")]
        public string ShortName { get; set; }

        [JsonProperty("max_rarity")]
        public int MaxRarity { get; set; }

        [JsonProperty("traits")]
        public IList<string> Traits { get; set; }

        [JsonProperty("traits_named")]
        public IList<string> TraitsNamed { get; set; }

        [JsonProperty("traits_hidden")]
        public IList<string> TraitsHidden { get; set; }

        [JsonProperty("imageUrlPortrait")]
        public string ImageUrlPortrait { get; set; }

        [JsonProperty("collections")]
        public IList<string> Collections { get; set; }

        [JsonProperty("totalChronCost")]
        public int TotalChronCost { get; set; }

        [JsonProperty("factionOnlyTotal")]
        public int FactionOnlyTotal { get; set; }

        [JsonProperty("craftCost")]
        public int CraftCost { get; set; }

        [JsonProperty("bigbook_tier")]
        public int BigbookTier { get; set; }

        [JsonProperty("events")]
        public int Events { get; set; }

        [JsonProperty("ranks")]
        [JsonConverter(typeof(RanksConverter))]
        public Ranks Ranks { get; set; }

		[JsonProperty("base_skills")]
		[JsonConverter(typeof(BaseSkillsConverter))]
		public List<Skill> BaseSkills { get; set; }

		[JsonProperty("skill_data")]
		[JsonConverter(typeof(SkillDataConverter))]
		public List<Skill>[] SkillData { get; set; }

		[JsonProperty("in_portal")]
		public bool InPortal { get; set; }

		[JsonProperty("markdownContent")]
		public string MarkdownContent { get; set; }

		[JsonProperty("action")]
		public Action Action { get; set; }

		[JsonProperty("ship_battle")]
		public ShipBattle ShipBattle { get; set; }
	}

}
