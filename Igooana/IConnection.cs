using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Igooana {
  internal interface IConnection {
    Task<String> PostStringAsync(Uri uri, IDictionary<String, String> content);
  }
}
