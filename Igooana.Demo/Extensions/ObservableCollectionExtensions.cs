using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Igooana.Demo.Extensions {
  public static class ObservableCollectionExtensions {
    public static void AddMany<T>(this ObservableCollection<T> collection, IEnumerable<T> items) {
      foreach (T t in items) {
        collection.Add(t);
      }
    }
  }
}
