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

		public partial class AntiMacro
		{
			[JsonProperty("min_minutes_to_popup")]
			public long MinMinutesToPopup { get; set; }

			[JsonProperty("variable_minutes_to_popup")]
			public long VariableMinutesToPopup { get; set; }
		}
	}
}