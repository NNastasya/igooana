using Igooana.Extensions;
using Igooana.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Igooana {
  public class Response {
    private Response(){}
    public dynamic Totals { get; set; }
    public IEnumerable<dynamic> Values { get; set; }

    internal static async Task<Response> Parse(string json) {
      var jsonResponse = await json.ToObjectAsync<JsonResponse>();
      return new Response();
    }
  }
}
