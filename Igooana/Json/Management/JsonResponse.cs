using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Igooana.Json.Management {
  internal class JsonResponse<T> {
    [JsonProperty(PropertyName="totalResults")]
    public int TotalResults { get; set; }
    [JsonProperty(PropertyName="startIndex")]
    public int StartIndex { get; set; }
    [JsonProperty(PropertyName="itemsPerPage")]
    public int ItemsPerPage { get; set; }
    [JsonProperty(PropertyName="items")]
    public T[] Items { get; set; }
  }
}
