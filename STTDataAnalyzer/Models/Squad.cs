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

		public partial class Squad
		{
			[JsonProperty("id")]
			public long Id { get; set; }

			[JsonProperty("rank")]
			public string Rank { get; set; }
		}
	}
}
