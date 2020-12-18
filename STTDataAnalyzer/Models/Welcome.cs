using Newtonsoft.Json;

namespace STTDataAnalyzer
{

	namespace SttUser
	{
		public partial class Welcome
		{
			public static Welcome FromJson(string json)
			{
				return JsonConvert.DeserializeObject<Welcome>(json, SttUser.Converter.Settings);
			}

			[JsonProperty("action")]
			public string Action { get; set; }

			[JsonProperty("player")]
			public Player Player { get; set; }

			[JsonProperty("item_archetype_cache")]
			public ItemArchetypeCache ItemArchetypeCache { get; set; }
		}
	}
}
