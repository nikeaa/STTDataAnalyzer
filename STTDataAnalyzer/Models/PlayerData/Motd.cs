using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
	{
		public partial class PdMotd
		{
			[JsonProperty("title")]
			public string Title { get; set; }

			[JsonProperty("text")]
			public string Text { get; set; }

			[JsonProperty("priority")]
			public long Priority { get; set; }

			[JsonProperty("image")]
			public PdIconClass Image { get; set; }

			[JsonProperty("url")]
			public object Url { get; set; }

			[JsonProperty("additional_motds")]
			public List<object> AdditionalMotds { get; set; }
		}
	}
