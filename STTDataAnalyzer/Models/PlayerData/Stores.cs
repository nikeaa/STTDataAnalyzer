using Newtonsoft.Json;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PdStores
	{
		[JsonProperty("SOCIAL.GUILD.INVITE")]
		public long SocialGuildInvite { get; set; }
	}
}
