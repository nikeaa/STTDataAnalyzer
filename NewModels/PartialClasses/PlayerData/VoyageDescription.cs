using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STTDataAnalyzer.Models.PlayerData
{
    public partial class VoyageDescription
    {
        public override string ToString()
        {
            string result = $"{Name}\r\nShip Trait: {ShipTrait}\r\nPrimarySkill: {Skills.PrimarySkill}\r\nSecondary Skill: {Skills.SecondarySkill}\r\n";

            foreach (CrewSlot cs in CrewSlots)
            {
                result += $"{cs.Name}: {cs.Skill} - {cs.Trait}\r\n";
            }

            return result;
        }
    }
    /*
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("symbol")]
            public string Symbol { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("icon")]
            public string Icon { get; set; }

            [JsonProperty("skills")]
            public VoyageSkills Skills { get; set; }

            [JsonProperty("ship_trait")]
            public string ShipTrait { get; set; }

            [JsonProperty("crew_slots")]
            public List<CrewSlot> CrewSlots { get; set; }

            [JsonProperty("potential_rewards")]
            public List<PotentialRewardElement> PotentialRewards { get; set; }
    */
}
