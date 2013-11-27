using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Igooana {
  internal class Connection : IConnection{
    public Connection() {
    }

    #region Methods

    public async Task<String> PostStringAsync(Uri uri, IDictionary<String, String> content) {
      using (var http = new HttpClient()) {
        var formContent = new FormUrlEncodedContent(content);
        var response = await http.PostAsync(uri, formContent);
        return await response.Content.ReadAsStringAsync();
      }
    }

    #endregion
  }
}
