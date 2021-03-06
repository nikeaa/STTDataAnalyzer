using Newtonsoft.Json;
using STTDataAnalyzer.Converters;
using System.Configuration;
using System.IO;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PlayerData
	{
		public string Path = ConfigurationManager.AppSettings["Path"];

		[JsonProperty("action")]
		public string Action { get; set; }

		[JsonProperty("player")]
		public PdPlayer Player { get; set; }

		[JsonProperty("item_archetype_cache")]
		public PdItemArchetypeCache ItemArchetypeCache { get; set; }

		private const string FileName = "PlayerData.json";

		public PlayerData(string fileName = FileName)
		{
			if (fileName != null)
			{
				PlayerData temp = JsonConvert.DeserializeObject<PlayerData>(File.ReadAllText(Path + fileName), Converter.Settings);
				Action = temp.Action;
				ItemArchetypeCache = temp.ItemArchetypeCache;
				Player = temp.Player;
			}
		}
	}
}
