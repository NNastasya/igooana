using Igooana.Extensions;
using Igooana.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Igooana {
  public class Response {
    private Response(){}
    public dynamic Totals { get; set; }
    public IEnumerable<dynamic> Values { get; set; }

    internal static async Task<Response> Parse(string json) {
      var jsonResponse = await json.ToObjectAsync<JsonResponse>();
      return new Response { Values = ParseValues(jsonResponse.Values, jsonResponse.ColumnHeaders) };
    }

    private static IEnumerable<dynamic> ParseValues(string[][] values, IList<ResponseColumn> columns) {
      var columnTypes = columns.Select(c => GetTypeFromAnalyticsType(c.DataType)).ToList();
      var propertyNames = columns.Select(c => PropertizeGaColumnName(c.Name)).ToList();
      return values.Select(x => {
        dynamic resultValue = new ExpandoObject();
        IDictionary<string, object> resultAsDic = resultValue;
        for (int i = 0; i < x.Length; i++) {
          resultAsDic[propertyNames[i]] = Convert.ChangeType(x[i], columnTypes[i]);
        }
        return resultValue;
      });
    }

    private static Type GetTypeFromAnalyticsType(string analyticsType) {
      switch (analyticsType) {
        case "INTEGER": return typeof(int);
        case "FLOAT": 
        case "PERCENT":
          return typeof(float);
        case "STRING": return typeof(string);
        default: return typeof(string);
      }
    }
    
    private static string PropertizeGaColumnName(string gaColumnName) {
      var propertyChars = gaColumnName.Split(':')[1].ToCharArray();
      propertyChars[0] = Char.ToUpper(propertyChars[0]);
      return new string(propertyChars);
    }
  }
}
