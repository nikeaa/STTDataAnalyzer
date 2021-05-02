using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using STTDataAnalyzer.Converters;
using System.Configuration;
using System.IO;

namespace STTDataAnalyzer.Models.PlayerData
{
	public partial class PlayerData : BaseData
	{
		[JsonProperty("action")]
		public string Action { get; set; }

		[JsonProperty("player")]
		public PdPlayer Player { get; set; }

		[JsonProperty("item_archetype_cache")]
		public PdItemArchetypeCache ItemArchetypeCache { get; set; }

		private readonly string FileName = ConfigurationManager.AppSettings["PlayerDataFileName"];

		public PlayerData() {
			JObject playerData = JObject.Parse(File.ReadAllText(Path + FileName));
			JToken action = playerData["action"];
			Action = action.ToString();
			JToken player = playerData["player"];
			Player = player.ToObject<PdPlayer>();
			JToken items = playerData["item_archetype_cache"];
			ItemArchetypeCache = items.ToObject<PdItemArchetypeCache>();
		}

		public PlayerData(string fileName)
		{
			JObject playerData = JObject.Parse(File.ReadAllText(Path + fileName));
			JToken action = playerData["action"];
			Action = action.ToString();
			JToken player = playerData["player"];
			Player = player.ToObject<PdPlayer>();
			JToken items = playerData["item_archetype_cache"];
			ItemArchetypeCache = items.ToObject<PdItemArchetypeCache>();
		}
	}
}
