using System;
using System.Collections.Generic;

namespace STTDataAnalyzer.Utilities.ExtensionMethods
{
	public static class IEnumerableExtensionMethods
	{
		public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
		{
			foreach (T item in source)
			{
				action(item);
			}
		}
	}
}
