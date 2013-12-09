using System;
using System.Net;
using System.Text.RegularExpressions;

namespace Igooana.Extensions {
  internal static class StringExtensions {
    internal static string UrlEncoded(this string input) {
      return WebUtility.UrlEncode(input);
    }

    internal static string FormatWith(this string format, params object[] args){
      return String.Format(format, args);
    }

    internal static bool IsGaDate(this string input) {
      if (String.IsNullOrWhiteSpace(input)) {
        return false;
      }
      return Regex.IsMatch(input, @"(?:1|2)\d{3}(?:01|02|03|04|05|06|07|08|09|10|11|12)(?:0|1|2|3)[0-9]");
    }
  }
}
