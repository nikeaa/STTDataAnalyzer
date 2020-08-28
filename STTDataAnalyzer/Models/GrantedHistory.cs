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
		using System;

		public partial class GrantedHistory
		{
			[JsonProperty("what")]
			public FromEnum What { get; set; }

			[JsonProperty("when")]
			public DateTimeOffset When { get; set; }

			[JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
			public FromEnum? To { get; set; }

			[JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
			public FromEnum? From { get; set; }

			[JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
			public Reason? Reason { get; set; }
		}
	}
}
