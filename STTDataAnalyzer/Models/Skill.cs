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

		public partial class Skill
		{
			[JsonProperty("core")]
			public long Core { get; set; }

			[JsonProperty("range_min")]
			public long RangeMin { get; set; }

			[JsonProperty("range_max")]
			public long RangeMax { get; set; }
		}
	}
}