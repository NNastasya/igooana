namespace Igooana.Dimensions {
  public class Time {
    internal Time() { }
    /// <summary>
    /// The date of the visit
    /// </summary>
    public  readonly Dimension Date = new Dimension("ga:date", "Time", "The date of the visit");
  }
}
