using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace STTDataAnalyzer.Models.Static
{
	public class Action
	{
		[JsonProperty("bonus_amount")]
		public int BonusAmount { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("cooldown")]
		public int Cooldown { get; set; }

		[JsonProperty("initial_cooldown")]
		public int InitialCooldown { get; set; }

		[JsonProperty("duration")]
		public int Duration { get; set; }

		[JsonProperty("bonus_type")]
		public int BonusType { get; set; }

		[JsonProperty("crew")]
		public int? Crew { get; set; }

		[JsonProperty("crew_archetype_id")]
		public int? CrewArchetypeId { get; set; }

		[JsonProperty("icon")]
		public Icon Icon { get; set; }

		[JsonProperty("ability")]
		public Ability Ability { get; set; }

		[JsonProperty("special")]
		public bool Special { get; set; }
	}
}
