using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdMission
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("speaker")]
		public string Speaker { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("portrait")]
		public PdIconClass Portrait { get; set; }

		[JsonProperty("image")]
		public PdIconClass Image { get; set; }

		[JsonProperty("image_small")]
		public PdIconClass ImageSmall { get; set; }

		[JsonProperty("requirement")]
		public string Requirement { get; set; }
	}
}
