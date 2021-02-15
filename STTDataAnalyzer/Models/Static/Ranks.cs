using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace STTDataAnalyzer
{
	public class Ranks
	{
		public Ranks() {

		}

        /*
        "archetype_id": 9998,
        "symbol": "federation_president_crew",
        "name": "UFP President Ra-ghoratreii",
        "short_name": "Ra-ghoratreii",
        "max_rarity": 5,
        "traits": ["efrosian", "cultural_figure", "federation", "president", "diplomat"],
        "traits_named": ["Efrosian", "Cultural Figure", "Federation", "President", "Diplomat"],
        "traits_hidden": ["nonhuman", "male", "organic", "tos", "federation_president", "crew_max_rarity_5"],
        "imageUrlPortrait": "crew_portraits_cm_federation_president_sm.png",
        "collections": ["New Life and New Civilizations"],
        "totalChronCost": 1619,
        "factionOnlyTotal": 44,
        "craftCost": 709350,
        "bigbook_tier": 8,
        "events": 0,
        "in_portal": true,
        "markdownContent": "A good stats comparison would ironically be Chancellor Gorkon whose primary base and voyage numbers are both within single digits. It stings a bit to see a gaping hole where his event chances should be since he's carrying such strong bases, but at least they're plenty usable for daily shuttles. Rigatoni's \"real feel\" voyage ability will disappoint as a DIP primary with his skill set. The raw stats shine through once fused, but will sink like a stone and his voyage combo versatility remains low. With a redundant skill set and no events or peripheral perks to look forward to, try not to be blinded by the stats and think carefully about how much of an upgrade Ravioli would be to your current CMD/DIP/SEC options.",
		 */
        public int VoyageRank;

		public int GauntletRank;

		public int ChronsCostRank;

		public Dictionary<string, int> BaseRanks;
		public Dictionary<string, int> AverageRanks;

		public Tuple<string, string, int> VoyagePairRanks;
		public Tuple<string, string, int> GauntletPairRanks;

        public Tuple<string, int, int, int> BaseSkills;

        public Tuple<string, int, int, int>[] SkillData;
	}
}