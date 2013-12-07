using Igooana.Extensions;
using System.Net;
using System.Net.Http;

namespace Igooana {
  public class ConnectionException : WebException {
    private readonly int statusCode;
    private readonly string reason;
    private readonly Error details;
    

    internal ConnectionException(HttpResponseMessage response) {
      statusCode = (int)response.StatusCode;
      reason = response.ReasonPhrase;
      string content = response.Content.ReadAsStringAsync().Result;
      ResponseContent responseContent = content.ToObject<ResponseContent>();
      details = responseContent.Error;
    }

    public int StatusCode { get { return statusCode; } }
    public string Reason { get { return reason; } }

    public override string Message {
      get {
        return "{0} ({1})".FormatWith(reason, statusCode);
      }
    }

    public string DetailedMessage {
      get {
        return "{0}\n{1}".FormatWith(Message, details.message);
      }
    }

    private class ResponseContent {
      public Error Error { get; set; }
    }

    public class Error {
      public int code { get; set; }
      public string message { get; set; }
      public object[] errors { get; set; }
    }
  }
}
