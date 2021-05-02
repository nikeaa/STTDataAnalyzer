using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdCrewAvatar
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("traits")]
		public List<string> Traits { get; set; }

		[JsonProperty("traits_hidden")]
		public List<string> TraitsHidden { get; set; }

		[JsonProperty("short_name")]
		public string ShortName { get; set; }

		[JsonProperty("max_rarity")]
		public long MaxRarity { get; set; }

		[JsonProperty("icon")]
		public PdIconClass Icon { get; set; }

		[JsonProperty("portrait")]
		public PdIconClass Portrait { get; set; }

		[JsonProperty("full_body")]
		public PdIconClass FullBody { get; set; }

		[JsonProperty("default_avatar")]
		public bool DefaultAvatar { get; set; }

		[JsonProperty("hide_from_cryo")]
		public bool HideFromCryo { get; set; }

		[JsonProperty("skills", ItemConverterType = typeof(StringEnumConverter))]
		public List<PdSkillElement> Skills { get; set; }
	}
}
