using System;

namespace Igooana {
  public class Query {
    private readonly DateTime dt1;
    private readonly DateTime dt2;
    private readonly Metric metric = Metric.Empty;
    private readonly Dimension dimension = Dimension.Empty;
    private Query(DateTime dt1, DateTime dt2) {
      this.dt1 = dt1;
      this.dt2 = dt2;
    }
    private Query(DateTime dt1, DateTime dt2, Metric metric, Dimension dimension)
      : this(dt1, dt2) {
      this.metric = metric;
      this.dimension = dimension;
    }

    public static Query Between(DateTime dt1, DateTime dt2) {
      return new Query(dt1, dt2);
    }

    public Query WithMetrics(Func<Metric, Metric> func) {
      return new Query(dt1, dt2, func(metric), dimension);

    }

    public Query WithDimensions(Func<Dimension, Dimension> func) {
      return new Query(dt1, dt2, metric, func(dimension));
    }
  }
}
