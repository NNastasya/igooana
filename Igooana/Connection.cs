using Igooana.Extensions;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Igooana {
  internal class Connection : IConnection {

    #region Methods

    public async Task<String> PostStringAsync(Uri uri, IDictionary<String, String> content) {
      using (var http = new HttpClient()) {
        var formContent = new FormUrlEncodedContent(content);
        var response = await http.PostAsync(uri, formContent);
        return await response.Content.ReadAsStringAsync();
      }
    }

    public async Task<String> GetStringAsync(Uri uri, string accessToken = null) {
      using (var http = new HttpClient()) {
        if (accessToken != null) {
          http.DefaultRequestHeaders.Add("Authorization", "Bearer {0}".FormatWith(accessToken));
        }
        var response = await http.GetAsync(uri);
        if (response.IsSuccessStatusCode) {
          return await response.Content.ReadAsStringAsync();
        }
        else {
          throw new ConnectionException(response);
        }
      }
    }

    #endregion
  }
}
