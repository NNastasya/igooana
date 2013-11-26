using System;
using System.Collections.Generic;
using System.Linq;

namespace Igooana.Extensions {
  internal static class CollectionExtensions {
    internal static string ToUrlQuery(this IDictionary<string, string> dic) {
      // TODO: does String.join use StringBuilder internally?
      var values = dic.Select(pair => "{0}={1}".FormatWith(pair.Key.UrlEncoded(), pair.Value.UrlEncoded()));
      return String.Join("&", values);
    }
  }
}
