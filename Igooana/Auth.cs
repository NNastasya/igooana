using System;
using System.Collections.Generic;
using Igooana.Extensions;

namespace Igooana {
  internal class Auth {
    #region Fields

    const string scheme = "https://";
    const string host = "accounts.google.com";
    const string authenticationPath = "/o/oauth2/auth";
    const string scope = "https://www.googleapis.com/auth/analytics.readonly";
    string redirectUri = "http://localhost";
    readonly string clientId;
    readonly string clientSecret;

    #endregion

    internal Auth(string clientId, string clientSecret) {
      this.clientId = clientId;
      this.clientSecret = clientSecret;
    }


    internal void AuthContinueCallback(string authenticationCode) {
      //var accessTokenUrl = BuildAccessTokenUri();
      //var webClient = new WebClient();
      //webClient.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
      //string data = string.Format("code={0}&client_id={1}&client_secret={2}&redirect_uri={3}&grant_type=authorization_code", authenticationCode, _clientId, _clientSecret, _redirectUri);
      //webClient.UploadStringCompleted += (o, e) => {
      //  _accessTokenResponse = JsonSerializer.DeserializeFromString<AccessTokenResponse>(e.Result);
      //  if (ConnectionOpened != null) {
      //    ConnectionOpened(this, new ConnectionOpenedEventArgs { Response = _accessTokenResponse });
      //  }
      //};
      //webClient.UploadStringAsync(accessTokenUrl, data);
    }
    internal Uri BuildAuthUri() {
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
  }
}
