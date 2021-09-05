using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class UpcomingEvent
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("dates")]
		public string Dates { get; set; }

		[JsonProperty("startDate")]
		public DateTime StartDate { get; set; }

		[JsonProperty("endDate")]
		public DateTime EndDate { get; set; }

		[JsonProperty("highbonus")]
		public string[] HighBonus { get; set; }

		[JsonProperty("smallbonus")]
		public SmallBonus SmallBonus { get; set; }
	}
}
