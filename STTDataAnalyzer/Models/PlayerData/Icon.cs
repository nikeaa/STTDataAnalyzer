using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdIcon
	{
		[JsonProperty("file")]
		public string File { get; set; }

		[JsonProperty("atlas_info", NullValueHandling = NullValueHandling.Ignore)]
		public PdAtlasInfo? AtlasInfo { get; set; }
	}
}
