using System;
using System.Net;

namespace Igooana {
  public class Metric {
    private readonly string _metricString;
    public static readonly Metric Empty = new Metric("");
    public readonly Metric Visits = new Metric("ga:visits");
    public readonly Metric Visitors = new Metric("ga:visitors");
    public readonly Metric PageViewsPerVisit = new Metric("ga:pageViewsPerVisit");
    public readonly Metric AverageTimeOnSite = new Metric("ga:avgTimeOnSite");
    public readonly Metric PercentNewVisits = new Metric("ga:percentNewVisits");
    public readonly Metric PageViews = new Metric("ga:pageviews");

    protected Metric(string metricString) {
      _metricString = metricString;
    }


    public static Metric operator +(Metric m1, Metric m2) {
      if (object.ReferenceEquals(m1, m2)) throw new InvalidOperationException("Addition must use two different metric instances");
      return Add(m1, m2);
    }

    public static Metric Add(Metric m1, Metric m2) {
      return new Metric(string.Format("{0},{1}", m1._metricString, m2._metricString));
    }

    public static bool operator ==(Metric m1, Metric m2) {
      return m1._metricString == m2._metricString;
    }

    public static bool operator !=(Metric m1, Metric m2) {
      return !(m1 == m2);
    }

    public override bool Equals(object obj) {
      Metric other = obj as Metric;
      if (other == null) return false;
      return this == other;
    }

    public override int GetHashCode() {
      return _metricString.GetHashCode();
    }
  }
}
