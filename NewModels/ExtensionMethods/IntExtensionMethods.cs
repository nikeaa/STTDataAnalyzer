namespace STTDataAnalyzer.Models
	.ExtensionMethods
{
	public static class IntExtensionMethods
	{
		public static string ToHoursMinutes(this int source)
		{
			int hours = (int)(source / 3600);
			int seconds = source % 3600;
			int minutes = (int)(seconds / 60);
			string zero = minutes < 10 ? "0" : "";

			return hours.ToString() + ":" + zero + minutes.ToString();
		}
	}
}
