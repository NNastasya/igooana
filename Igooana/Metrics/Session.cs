namespace Igooana.Metrics {
  public class Session {
    internal Session() { }

    /// <summary>
    /// Counts the total number of sessions.
    /// </summary>
    public readonly Metric Visits = new Metric("ga:visits", "Session", "Counts the total number of sessions.");

    /// <summary>
    /// The total number of single page (or single engagement hit) sessions for your property. 
    /// </summary>
    public readonly Metric Bounces = new Metric("ga:bounces", "Session", "The total number of single page (or single engagement hit) sessions for your property.");

    /// <summary>
    /// The percentage of single-page visits (i.e. visits in which the person left your property from the entrance page). 
    /// </summary>
    public readonly Metric EntranceBounceRate = new Metric("ga:entranceBounceRate", "Session", "The percentage of single-page visits (i.e. visits in which the person left your property from the entrance page).");

    /// <summary>
    /// The percentage of single-page visits (i.e., visits in which the person left your property from the first page). 
    /// </summary>
    public readonly Metric VisitBounceRate = new Metric("ga:visitBounceRate", "Session", "The percentage of single-page visits (i.e., visits in which the person left your property from the first page).");

    /// <summary>
    /// The total duration of visitor sessions represented in total seconds. 
    /// </summary>
    public readonly Metric TimeOnSite = new Metric("ga:timeOnSite", "Session", "The total duration of visitor sessions represented in total seconds.");

    /// <summary>
    /// The average duration visitor sessions represented in total seconds. 
    /// </summary>
    public readonly Metric AvgTimeOnSite = new Metric("ga:avgTimeOnSite", "Session", "The average duration visitor sessions represented in total seconds.");
  }
}
