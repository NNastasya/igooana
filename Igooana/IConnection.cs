using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Igooana {
  public interface IConnection {
    Task<String> PostStringAsync(Uri uri, IDictionary<String, String> content);
    Task<String> GetStringAsync(Uri uri, string authenticationToken = null);
  }
}
