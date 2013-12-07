using System;
using System.Threading.Tasks;
using Igooana.Extensions;
using Newtonsoft.Json.Linq;

namespace Igooana {
  public class Api : Igooana.IApi {
    private const string baseUrl = "https://www.googleapis.com";
    private const string basePath = "/analytics/v3/data/ga";
    private readonly IConnection connection;
    private readonly IAuth auth;
    private Management management;
    private string token;

    internal Api(IConnection connection, IAuth auth) {
      this.connection = connection;
      this.auth = auth;
    }

    public Api(string clientId, string clientSecret)
      : this(new Connection(), new Auth(clientId, clientSecret)) {
    }

    public Uri AuthenticateUri {
      get {
        return auth.BuildAuthUri();
      }
    }

    public Management Management {
      get {
        if (String.IsNullOrEmpty(token)) {
          throw new InvalidOperationException("You must authenticate before using management API");
        }
        return management ?? (management = new Management(connection, token));
      }
    }

    /// <summary>
    /// Performs OAuth2 authentication, given the browser uri 
    /// </summary>
    /// <param name="uri">Current browser uri</param>
    /// <exception>AccessRefusedException when user clicks `Cancel` on access confirmation page</exception>
    /// <returns></returns>
    public async Task<bool> Authenticate(Uri uri) {
      if (uri.Host == "localhost") {
        var tokenParams = auth.BuildTokenParams(uri);
        var response = await connection.PostStringAsync(auth.BuildTokenUri(), tokenParams);
        // TODO: move json stuff somewhere else
        token = JObject.Parse(response)["access_token"].ToString();
        return !String.IsNullOrEmpty(token);
      }
      else return false;
    }

    public async Task<dynamic> Execute(Query query) {
      var builder = new UriBuilder(baseUrl);
      builder.Path = basePath;
      builder.Query = query.ToString();
      var jsonResponse = await connection.GetStringAsync(builder.Uri, token);
      return await jsonResponse.ToObjectAsync<dynamic>();
    }
  }
}
