using System;


namespace Igooana {
  public class Dimension {
    private readonly string _dimensionString;
    public static readonly Dimension Empty = new Dimension("");
    public static readonly Dimension Browser = new Dimension("ga:browser");
    public static readonly Dimension Date = new Dimension("ga:date");
    public static readonly Dimension PagePath = new Dimension("ga:pagepath");

    protected Dimension(string dimensionString) {
      _dimensionString = dimensionString;
    }

    public bool IsEmpty {
      get {
        return String.IsNullOrEmpty(_dimensionString);
      }
    }

    public static Dimension operator +(Dimension d1, Dimension d2) {
      return Add(d1, d2);
    }

    public static Dimension Add(Dimension d1, Dimension d2) {
      return new Dimension(string.Format("{0},{1}", d1._dimensionString, d2._dimensionString));
    }
  }
}
