using System;
using Igooana.Extensions;
using Igooana.Metrics;

namespace Igooana {
  public class Metric {

    #region Fields

    private readonly string metricString;
    private string category;
    private string description;
    public static readonly Metric Empty = new EmptyMetric();

    public static readonly Visitor Visitor = new Visitor();
    public static readonly Session Session = new Session();
    public static readonly TrafficSources TrafficSources = new TrafficSources();
    public static readonly Adwords Adwords = new Adwords();
    public static readonly GoalConversions GoalConversions = new GoalConversions();
    public static readonly SocialActivity SocialActivity = new SocialActivity();
    public static readonly PageTracking PageTracking = new PageTracking();
    public static readonly SiteSpeed SiteSpeed = new SiteSpeed();
    public static readonly AppTracking AppTracking = new AppTracking();
    public static readonly EventTracking EventTracking = new EventTracking();

    #endregion

    #region Ctor

    protected internal Metric(string metricString, string category = null, string description = null)
    {
      this.metricString = metricString;
      this.category = category;
      this.description = description;
    }

    #endregion

    #region Properties

    public string Category { get { return category; } }
    public string Description { get { return description; } }

    public bool IsEmpty {
      get {
        return String.IsNullOrEmpty(metricString);
      }
    }

    public virtual string UrlSeparator {
      get { return ","; }
    }

    #endregion

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
