﻿namespace STTDataAnalyzer
{

	// <auto-generated />
	//
	// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
	//
	//    using SttUser;
	//
	//    var welcome = Welcome.FromJson(jsonString);

	namespace SttUser
	{
		using Newtonsoft.Json;

		public partial class Buff
		{
			[JsonProperty("name")]
			public string Name { get; set; }

			[JsonProperty("short_name")]
			public string ShortName { get; set; }

			[JsonProperty("flavor")]
			public string Flavor { get; set; }

			[JsonProperty("icon")]
			public IconClass Icon { get; set; }

			[JsonProperty("operator")]
			public Operator Operator { get; set; }

			[JsonProperty("value")]
			public double Value { get; set; }

			[JsonProperty("stat")]
			public string Stat { get; set; }

			[JsonProperty("source")]
			public Source Source { get; set; }

			[JsonProperty("symbol")]
			public string Symbol { get; set; }
		}
	}
}
