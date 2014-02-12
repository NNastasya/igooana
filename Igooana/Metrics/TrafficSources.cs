namespace Igooana.Metrics {
  public class TrafficSources {
    internal TrafficSources() { }

    /// <summary>
    /// The average duration visitor sessions represented in total seconds. 
    /// </summary>
    public readonly Metric OrganicSearches = new Metric("ga:organicSearches", "Traffic sources", "The number of organic searches that happened within a session. This metric is search engine agnostic.");
  }
}
