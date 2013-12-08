using Newtonsoft.Json;

namespace Igooana.Json {
  internal class ResponseColumn {

    [JsonProperty(PropertyName="name")]
    public string Name { get; set; }
    [JsonProperty(PropertyName="columnType")]
    public string ColumnType { get; set; }
    [JsonProperty(PropertyName="dataType")]
    public string DataType { get; set; }
  }
}
