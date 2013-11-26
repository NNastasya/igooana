using System;
using System.Net;

namespace Igooana.Extensions {
  internal static class StringExtensions {
    internal static string UrlEncoded(this string input) {
      return WebUtility.UrlEncode(input);
    }

    internal static string FormatWith(this string format, params object[] args){
      return String.Format(format, args);
    }
  }
}
