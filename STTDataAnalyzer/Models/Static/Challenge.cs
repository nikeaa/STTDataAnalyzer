using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class Challenge
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("grid_x")]
		public int GridX { get; set; }

		[JsonProperty("grid_y")]
		public int GridY { get; set; }

		[JsonProperty("skill")]
		public string Skill { get; set; }

		[JsonProperty("image")]
		public Icon Image { get; set; }

		[JsonProperty("difficulty")]
		public int Difficulty { get; set; }

		[JsonProperty("children")]
		public int[] Children { get; set; }

		[JsonProperty("locks")]
		public Lock[] Locks { get; set; }

		[JsonProperty("trait_bonuses")]
		public TraitBonus[] TraitBonuses { get; set; }

		[JsonProperty("difficulty_by_mastery")]
		public int[] DifficultyByMastery { get; set; }
	}
}