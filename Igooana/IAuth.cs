using System;
using System.Collections.Generic;
namespace Igooana {
  interface IAuth {
    IDictionary<String, String> BuildTokenParams(Uri uri);

    Uri BuildAuthUri();

    Uri BuildTokenUri();
  }
}
