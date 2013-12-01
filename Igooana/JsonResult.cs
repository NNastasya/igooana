using System.Collections.Generic;
using System.Linq;

namespace Igooana {
  internal class JsonResult<T> {
    public int totalResults { get; set; }
    public int startIndex { get; set; }
    public int itemsPerPage { get; set; }
    public T[] items { get; set; }
  }
}
