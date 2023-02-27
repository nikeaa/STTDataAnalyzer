using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.Static
{
	public class EventInstance
	{
		[JsonProperty("instance_id")]
		public int InstanceId { get; set; }

		[JsonProperty("fixed_instance_id")]
		public int FixedInstanceId { get; set; }

		[JsonProperty("event_id")]
		public int EventId { get; set; }

		[JsonProperty("event_name")]
		public string EventName { get; set; }

		[JsonProperty("image")]
		public string Image { get; set; }
	}
}
