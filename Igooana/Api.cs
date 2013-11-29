using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;

namespace Igooana {
  public class Api : Igooana.IApi {

    private readonly IConnection connection;
    private readonly IAuth auth;
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

    public async Task<object> Execute(Query query) {
      return null;
    }
  }
}
