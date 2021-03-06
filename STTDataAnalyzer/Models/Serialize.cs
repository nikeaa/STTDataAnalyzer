using Newtonsoft.Json;
using STTDataAnalyzer.Converters;

namespace STTDataAnalyzer.Models.PlayerData
{
	public static class Serialize
	{
		public static string ToJson(this PlayerData self)
		{
			return JsonConvert.SerializeObject(self, Converter.Settings);
		}
	}
}
