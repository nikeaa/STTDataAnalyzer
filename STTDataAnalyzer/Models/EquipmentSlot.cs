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

		public partial class EquipmentSlot
		{
			[JsonProperty("level")]
			public long Level { get; set; }

			[JsonProperty("archetype")]
			public long Archetype { get; set; }
		}
	}
}