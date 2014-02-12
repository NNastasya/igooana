namespace Igooana.Metrics {
  public class Visitor {
    internal Visitor() { }
    /// <summary>
    /// Total number of visitors to your property for the requested time period.
    /// </summary>
    public readonly Metric Visitors = new Metric("ga:visitors", "Visitor", "Total number of visitors to your property for the requested time period.");

    /// <summary>
    /// The number of visitors whose visit to your property was marked as a first-time visit. 
    /// </summary>
    public readonly Metric NewVisits = new Metric("ga:newVisits", "Visitor", "The number of visitors whose visit to your property was marked as a first-time visit.");

    /// <summary>
    /// The percentage of visits by people who had never visited your property before.
    /// </summary>
    public readonly Metric PercentNewVisits = new Metric("ga:percentNewVisits", "Visitor", "The percentage of visits by people who had never visited your property before.");
  }
}
