using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class MiscStats
	{
		[JsonProperty("alldemands")]
		public Demand[] AllDemands { get; set; }

		[JsonProperty("perFaction")]
		public PerFaction[] PerFactions { get; set; }

		[JsonProperty("perTrait")]
		public PerTrait[] PerTraits { get; set; }
	}
}
