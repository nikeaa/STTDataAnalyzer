using Newtonsoft.Json;
using System.Collections.Generic;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdAcceptedMission
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("episode")]
		public long Episode { get; set; }

		[JsonProperty("episode_title")]
		public string EpisodeTitle { get; set; }

		[JsonProperty("episode_portrait")]
		public PdIconClass EpisodePortrait { get; set; }

		[JsonProperty("marker")]
		public List<long> Marker { get; set; }

		[JsonProperty("marker_icon")]
		public PdIconClass MarkerIcon { get; set; }

		[JsonProperty("exclude_from_timeline")]
		public bool? ExcludeFromTimeline { get; set; }

		[JsonProperty("stars_earned")]
		public long StarsEarned { get; set; }

		[JsonProperty("total_stars")]
		public long TotalStars { get; set; }

		[JsonProperty("accepted")]
		public bool Accepted { get; set; }

		[JsonProperty("state")]
		public long State { get; set; }

		[JsonProperty("main_story")]
		public bool MainStory { get; set; }
	}
}
