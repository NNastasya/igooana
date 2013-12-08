using Igooana.Extensions;
using Igooana.Json.Management;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Igooana {
  public class Management {

    # region fields

    private readonly String baseUri = "https://www.googleapis.com/analytics/v3";
    private const string profilesPath = "/management/accounts/~all/webproperties/~all/profiles";
    private readonly string token;
    private readonly IConnection connection;

    #endregion

    internal Management(IConnection connection, string token) {
      this.connection = connection;
      this.token = token;
    }


    #region Methods

    public async Task<IEnumerable<Profile>> GetProfilesAsync() {
      var uri = new Uri("{0}{1}".FormatWith(baseUri, profilesPath));
      var profilesJson = await connection.GetStringAsync(uri, token);
      var jsonResult = profilesJson.ToObject<JsonResponse<Profile>>();
      return jsonResult.Items;
    }

    #endregion
  }
}
