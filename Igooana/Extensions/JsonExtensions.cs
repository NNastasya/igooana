using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Igooana.Extensions {
  public static class JsonExtensions {
    public static T ToObject<T>(this string input) {
      return JsonConvert.DeserializeObject<T>(input);
    }

    public static async Task<T> ToObjectAsync<T>(this string input) {
      return await JsonConvert.DeserializeObjectAsync<T>(input);
    }
  }
}
