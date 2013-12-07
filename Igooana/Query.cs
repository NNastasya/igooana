using Igooana.Extensions;
using System;
using System.Text;

namespace Igooana {
  public class Query {
    private readonly int profileId;
    private readonly DateTime dt1;
    private readonly DateTime dt2;
    private readonly Metric metric;
    private readonly Dimension dimension;

    private Query(int profileId, DateTime dt1, DateTime dt2, Metric metric = null, Dimension dimension = null) {
      this.profileId = profileId;
      this.dt1 = dt1;
      this.dt2 = dt2;
      this.metric = metric ?? Metric.Empty;
      this.dimension = dimension ?? Dimension.Empty;
    }

    public static Query For(int profileId, DateTime dt1, DateTime dt2) {
      return new Query(profileId, dt1, dt2);
    }

    public Query WithMetrics(Metric metric) {
      return new Query(profileId, dt1, dt2, this.metric + metric, dimension);
    }

    public Query WithDimensions(Dimension dimension) {
      return new Query(profileId, dt1, dt2, metric, this.dimension + dimension);
    }


    public override string ToString() {
      string dateFormat = "yyyy-MM-dd";
      string query = "ids=ga:{0}&start-date={1}&end-date={2}".FormatWith(profileId, dt1.ToString(dateFormat), dt2.ToString(dateFormat));
      var builder = new StringBuilder(query);
      if (!metric.IsEmpty) {
        builder.AppendFormat("&metrics={0}", metric);
      }
      if (!dimension.IsEmpty) {
        builder.AppendFormat("&dimensions={0}", dimension);
      }
      return builder.ToString();
    }
  }
}
