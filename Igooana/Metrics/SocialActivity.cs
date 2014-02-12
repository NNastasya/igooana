namespace Igooana.Metrics {
  public class SocialActivity {
    internal SocialActivity() { }

    /// <summary>
    /// The count of activities where a content URL was shared / mentioned on a social data hub partner network.
    /// </summary>
    public readonly Metric SocialActivities = new Metric("ga:socialActivities", "SocialActivities", "The count of activities where a content URL was shared / mentioned on a social data hub partner network.");
  }
}
