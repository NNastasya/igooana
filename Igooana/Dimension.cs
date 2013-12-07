using System;
using Igooana.Extensions;


namespace Igooana {
  public class Dimension {
    private readonly string dimensionString;
    public static readonly Dimension Empty = new EmptyDimension();
    public static readonly Dimension Browser = new Dimension("ga:browser");
    public static readonly Dimension Date = new Dimension("ga:date");
    public static readonly Dimension PagePath = new Dimension("ga:pagepath");

    protected Dimension(string dimensionString) {
      this.dimensionString = dimensionString;
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
