namespace Igooana.Metrics {
  public class AppTracking {
    internal AppTracking() { }

    /// <summary>
    /// The total number of screenviews.
    /// </summary>
    public readonly Metric ScreenViews = new Metric("ga:screenViews", "App Tracking", "The total number of screenviews.");

    /// <summary>
    /// The number of different (unique) screenviews within a session.
    /// </summary>
    public readonly Metric UniqueScreenViews = new Metric("ga:uniqueScreenViews", "App Tracking", "The number of different (unique) screenviews within a session.");

    /// <summary>
    /// The time spent viewing the current screen.
    /// </summary>
    public readonly Metric TimeOnScreen = new Metric("ga:timeOnScreen", "App Tracking", "The time spent viewing the current screen.");

    /// <summary>
    /// The average amount of time users spent on a screen in seconds.
    /// </summary>
    public readonly Metric AvgScreenviewDuration = new Metric("ga:avgScreenviewDuration", "App Tracking", "The average amount of time users spent on a screen in seconds.");

    /// <summary>
    /// The average number of screenviews per session.
    /// </summary>
    public readonly Metric ScreenviewsPerSession = new Metric("ga:screenviewsPerSession", "App Tracking", "The average number of screenviews per session.");
  }
}
