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
		using System.Collections.Generic;

		public partial class Mailbox
		{
			[JsonProperty("status")]
			public string Status { get; set; }

			[JsonProperty("sendable")]
			public long Sendable { get; set; }

			[JsonProperty("sent")]
			public long Sent { get; set; }

			[JsonProperty("accepted")]
			public long Accepted { get; set; }

			[JsonProperty("stores")]
			public Dictionary<string, long> Stores { get; set; }

			[JsonProperty("received")]
			public long Received { get; set; }
		}
	}
}