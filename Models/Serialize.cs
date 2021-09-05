using Newtonsoft.Json;
using STTDataAnalyzer.Models.PlayerData;

namespace STTDataAnalyzer.Models
{
	public static class Serialize
	{
		public static string ToJson(this PlayerData self)
		{
			return JsonConvert.SerializeObject(self, Converter.Settings);
		}
	}
}
