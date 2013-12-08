
using Newtonsoft.Json;
namespace Igooana.Json {
  internal class JsonResponse {
    [JsonProperty(PropertyName="columnHeaders")]
    public ResponseColumn[] ColumnHeaders { get; set; }

    [JsonProperty(PropertyName="rows")]
    public string[][] Values { get; set; }
  }
}
