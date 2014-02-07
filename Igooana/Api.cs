using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;

namespace Igooana {
  public class Api : Igooana.IApi {
    private const string baseUrl = "https://www.googleapis.com";
    private const string basePath = "/analytics/v3/data/ga";
    private static Api current;
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

    //TODO: not sure if this good code at all...
    /// <summary>
    /// Returns current API instance if API is authenticated. Throws NullReferenceException when not authenticated
    /// </summary>
    public static Api Current {
      get {
        if (current == null) {
          throw new NullReferenceException("Current API instance is not initialized, authenticate to initialize it");
        }
        return current;
      }
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
        if (String.IsNullOrEmpty(token)) {
          return false;
        } else {
          current = this;
          return true;
        }
      }
      else return false;
    }

    public async Task<Response> Execute(Query query) {
      var builder = new UriBuilder(baseUrl);
      builder.Path = basePath;
      builder.Query = query.ToString();
      var json = await connection.GetStringAsync(builder.Uri, token);
      return await Response.Parse(json);
    }
  }
}
