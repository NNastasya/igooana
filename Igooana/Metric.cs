using System;
using Igooana.Extensions;

namespace Igooana {
  public class Metric {
    private readonly string metricString;
    public static readonly Metric Empty = new EmptyMetric();
    public static readonly Metric Visits = new Metric("ga:visits");
    public static readonly Metric Visitors = new Metric("ga:visitors");
    public static readonly Metric PageViewsPerVisit = new Metric("ga:pageViewsPerVisit");
    public static readonly Metric AverageTimeOnSite = new Metric("ga:avgTimeOnSite");
    public static readonly Metric PercentNewVisits = new Metric("ga:percentNewVisits");
    public static readonly Metric PageViews = new Metric("ga:pageviews");

    protected Metric(string metricString) {
      this.metricString = metricString;
    }


    public bool IsEmpty {
      get {
        return String.IsNullOrEmpty(metricString);
      }
    }

    public virtual string UrlSeparator {
      get { return ","; }
    }


    public static Metric operator +(Metric m1, Metric m2) {
      Ensure.ArgumentNotNull(m1, "m1");
      Ensure.ArgumentNotNull(m2, "m2");
      return m1.Add(m2);
    }

    public Metric Add(Metric other) {
      if (object.ReferenceEquals(this, other)) {
        throw new InvalidOperationException("Addition must use two different metric instances");
      }
      // TODO: write tests for this
      return new Metric("{0}{1}{2}".FormatWith(metricString, UrlSeparator, other.metricString));
    }


    public override string ToString() {
      return metricString.UrlEncoded();
    }

    public class EmptyMetric : Metric {
      internal EmptyMetric() : base("") { }

      public override string UrlSeparator {
        get {
          return String.Empty;
        }
      }

    }
  }
}
