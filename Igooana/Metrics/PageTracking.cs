namespace Igooana.Metrics {
  public class PageTracking {
    internal PageTracking() { }

    /// <summary>
    /// The average value of this page or set of pages. Page Value is (ga:transactionRevenue + ga:goalValueAll) / ga:uniquePageviews (for the page or set of pages).
    /// </summary>
    public readonly Metric PageValue = new Metric("ga:pageValue", "Page tracking", "The average value of this page or set of pages. Page Value is (ga:transactionRevenue + ga:goalValueAll) / ga:uniquePageviews (for the page or set of pages).");

    /// <summary>
    /// The number of entrances to your property measured as the first pageview in a session. Typically used with landingPagePath
    /// </summary>
    public readonly Metric Entrances = new Metric("ga:entrances", "Page tracking", "The number of entrances to your property measured as the first pageview in a session. Typically used with landingPagePath");

    /// <summary>
    /// The total number of pageviews for your property.
    /// </summary>
    public readonly Metric PageViews = new Metric("ga:pageviews", "Page tracking", "The total number of pageviews for your property.");

    /// <summary>
    /// The number of different (unique) pages within a session. This takes into both the pagePath and pageTitle to determine uniqueness.
    /// </summary>
    public readonly Metric UniquePageViews = new Metric("ga:uniquePageviews", "Page tracking", "The number of different (unique) pages within a session. This takes into both the pagePath and pageTitle to determine uniqueness.");

    /// <summary>
    /// How long a visitor spent on a particular page in seconds. Calculated by subtracting the initial view time for a particular page from the initial view time for a subsequent page. Thus, this metric does not apply to exit pages for your property.
    /// </summary>
    public readonly Metric TimeOnPage = new Metric("ga:timeOnPage", "Page tracking", "How long a visitor spent on a particular page in seconds. Calculated by subtracting the initial view time for a particular page from the initial view time for a subsequent page. Thus, this metric does not apply to exit pages for your property.");

    /// <summary>
    /// The number of exits from your property.
    /// </summary>
    public readonly Metric Exits = new Metric("ga:exits", "Page tracking", "The number of exits from your property.");

    /// <summary>
    /// The percentage of pageviews in which this page was the entrance.
    /// </summary>
    public readonly Metric EntranceRate = new Metric("ga:entranceRate", "Page tracking", "The percentage of pageviews in which this page was the entrance.");

    /// <summary>
    /// The average number of pages viewed during a visit to your property. Repeated views of a single page are counted.
    /// </summary>
    public readonly Metric PageviewsPerVisit = new Metric("ga:pageviewsPerVisit", "Page tracking", "The average number of pages viewed during a visit to your property. Repeated views of a single page are counted.");

    /// <summary>
    /// The average amount of time visitors spent viewing this page or a set of pages.
    /// </summary>
    public readonly Metric AvgTimeOnPage = new Metric("ga:avgTimeOnPage", "Page tracking", "The average amount of time visitors spent viewing this page or a set of pages.");

    /// <summary>
    /// The percentage of exits from your property that occurred out of the total page views.
    /// </summary>
    public readonly Metric ExitRate = new Metric("ga:exitRate", "Page tracking", "The percentage of exits from your property that occurred out of the total page views.");
  }
}
