using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class Collection
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("crew")]
		public string[] Crew { get; set; }

		[JsonProperty("description")]
		public string Description;

		[JsonProperty("image")]
		public string Image;
	}
}
