namespace STTDataAnalyzer.Converters
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;
	using System.Globalization;

	//public partial class Welcome
	//{
	//	public static Welcome FromJson(string json)
	//	{
	//		return JsonConvert.DeserializeObject<Welcome>(json, SttUser.Converter.Settings);
	//	}
	//}

	//public static class Serialize
	//{
	//	public static string ToJson(this Welcome self)
	//	{
	//		return JsonConvert.SerializeObject(self, SttUser.Converter.Settings);
	//	}
	//}

	internal static class Converter
	{
		public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
		{
			MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
			DateParseHandling = DateParseHandling.None,
			Converters =
			{
				PdSkillElementConverter.Singleton,
				PdFullNameEnumConverter.Singleton,
				PdAtlasInfoConverter.Singleton,
				PdVideoAdChronitonBoostRewardSymbolConverter.Singleton,
				PdOperatorConverter.Singleton,
				PdSourceConverter.Singleton,
				PdPurpleNameConverter.Singleton,
				PdTutorialStateConverter.Singleton,
				PdFromEnumConverter.Singleton,
				PdReasonConverter.Singleton,
				PdSpecializedConverter.Singleton,
				PdGrantedSymbolConverter.Singleton,
				new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
			},
		};
	}
}
