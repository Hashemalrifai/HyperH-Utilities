using System;
namespace HyperH.Utilities.Extensions
{
	public static class StringExtensions
	{
		public static bool IsNullOrWhiteSpace(this string sourceString)
        {
			return string.IsNullOrWhiteSpace(sourceString);
        }

		public static bool HasValue(this string sourceString)
        {
			return !string.IsNullOrWhiteSpace(sourceString);
        }
	}
}
