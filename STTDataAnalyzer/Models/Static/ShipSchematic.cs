using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class ShipSchematic
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("icon")]
		public Icon Icon { get; set; }

		[JsonProperty("cost")]
		public int Cost { get; set; }

		[JsonProperty("ship")]
		public Ship Ship { get; set; }

		[JsonProperty("rarity")]
		public int Rarity { get; set; }
	}
}
