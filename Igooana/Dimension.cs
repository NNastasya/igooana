using System;
using Igooana.Extensions;
using Igooana.Dimensions;


namespace Igooana {
  public class Dimension {
    private readonly string dimensionString;
    private string category;
    private string description;
    public static readonly Dimension Empty = new EmptyDimension();

    public static readonly PageTracking PageTracking = new PageTracking();
    public static readonly PlatformOrDevice PlatformOrDevice = new PlatformOrDevice();
    public static readonly Time Time = new Time();
    public static readonly TrafficSources TrafficSources = new TrafficSources();

    protected internal Dimension(string dimensionString, string category = null, string description = null) {
      this.dimensionString = dimensionString;
      this.category = category;
      this.description = description;
    }

    public bool IsEmpty {
      get {
        return String.IsNullOrEmpty(dimensionString);
      }
    }
    public virtual string UrlSeparator {
      get { return ","; }
    }

    public static Dimension operator +(Dimension d1, Dimension d2) {
      Ensure.ArgumentNotNull(d1, "d1");
      Ensure.ArgumentNotNull(d2, "d2");
      return d1.Add(d2);
    }

    public Dimension Add(Dimension other) {
      if (object.ReferenceEquals(this, other)) {
        throw new InvalidOperationException("Addition must use two different dimension instances");
      }
      // TODO: write tests for this
      return new Dimension("{0}{1}{2}".FormatWith(dimensionString, UrlSeparator, other.dimensionString));
    }
    public override string ToString() {
      return dimensionString.UrlEncoded();
    }
    public class EmptyDimension : Dimension {
      internal EmptyDimension() : base("") { }

      public override string UrlSeparator {
        get {
          return String.Empty;
        }
      }
    }
  }
}
