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

		public partial class Cwin
		{
			[JsonProperty("open")]
			public long Open { get; set; }

			[JsonProperty("close")]
			public long Close { get; set; }
		}
	}
}