using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STTDataAnalyzer.Models.PlayerData
{
    public partial class VoyageDescription
    {
        public Character Character;
        public IOrderedEnumerable<ShipElement> PossibleShips => getVoyagePossibleShips();

        public override string ToString()
        {
            string result = $"{Name}\r\nShip Trait: {ShipTrait}\r\nPrimarySkill: {Skills.PrimarySkill}\r\nSecondary Skill: {Skills.SecondarySkill}\r\n";

            foreach (CrewSlot cs in CrewSlots)
            {
                result += $"{cs.Name}: {cs.Skill} - {cs.Trait}\r\n";
            }

            return result;
        }

        public void getVoyagePossibleCards()
        {
            foreach (CrewSlot cs in CrewSlots)
            {
                string trait = cs.Trait;
                ChallengeSkillEnum skill = cs.Skill;
                cs.PossibleCards = Character.Crew.Where(c => c.Traits.Contains(trait) && c.HasSkill(skill)).OrderByDescending(c => c.DoubleWeightedVoyageScore(Skills.PrimarySkill.ToString().Replace("Skill", ""), Skills.SecondarySkill.ToString().Replace("Skill", ""), trait));
            }
        }

        public IOrderedEnumerable<ShipElement> getVoyagePossibleShips()
        {
            IOrderedEnumerable<ShipElement> result = Character.Ships.Where(s => s.Traits.Contains(ShipTrait) && s.Antimatter == 2500).OrderBy(s => s.Name);
            if (result.Count() <= 0)
            {
                result = Character.Ships.Where(s => s.Antimatter == 2500).OrderBy(s => s.Name);
            }

            return result;
        }
    }
}
