using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class Keystone
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("short_name")]
		public string ShortName { get; set; }

		[JsonProperty("flavor")]
		public string Flafor { get; set; }

		[JsonProperty("icon")]
		public Icon Icon { get; set; }

		[JsonProperty("rarity")]
		public int Rarity { get; set; }

		[JsonProperty("filter")]
		public Filter Filter { get; set; }

		[JsonProperty("keystones")]
		public int[] Keystones { get; set; }

		[JsonProperty("crew_archetype_id")]
		public int CrewArchetypeId { get; set; }
	}
}
