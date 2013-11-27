using System;
using System.Collections.Generic;
using Igooana.Extensions;

namespace Igooana {
  internal class Auth : IAuth {
    #region Fields

    const string scheme = "https://";
    const string host = "accounts.google.com";

    const string authenticationPath = "/o/oauth2/auth";
    const string tokenPath = "/o/oauth2/token";

    const string scope = "https://www.googleapis.com/auth/analytics.readonly";
    const string redirectUri = "http://localhost";
    readonly string clientId;
    readonly string clientSecret;

    #endregion

    internal Auth(string clientId, string clientSecret) {
      this.clientId = clientId;
      this.clientSecret = clientSecret;
    }
    public Uri BuildAuthUri() {
      var builder = new UriBuilder();
      builder.Scheme = scheme;
      builder.Host = host;
      builder.Path = authenticationPath;
      builder.Query = new Dictionary<string, string>() { 
        {"response_type", "code"},
        {"client_id", clientId},
        {"clientSecret", clientSecret},
        {"scope", scope},
        {"redirect_uri", redirectUri}
      }.ToUrlQuery();
      return builder.Uri;
    }
    public Uri BuildTokenUri() {
      var builder = new UriBuilder();
      builder.Scheme = scheme;
      builder.Host = host;
      builder.Path = tokenPath;
      return builder.Uri;
    }


    public IDictionary<String, String> BuildTokenParams(Uri uri) {
      return new Dictionary<String, String>{
        {"code", GetAuthCode(uri)},
        {"client_id", clientId},
        {"client_secret", clientSecret},
        {"redirect_uri", redirectUri},
        {"grant_type", "authorization_code"}
      };
    }
    private string GetAuthCode(Uri uri) {
      string queryString = uri.Query.ToString();
      if (queryString.Contains("access_denied")) {
        throw new AccessRefusedException();
      }
      else {
        string authCode = queryString.Substring(queryString.IndexOf("code=") + 5);
        return authCode;
      }
    }
  }
}
