namespace Igooana.Metrics {
  public class SiteSpeed {
    internal SiteSpeed() { }

    /// <summary>
    /// Total Page Load Time is the amount of time (in milliseconds) it takes for pages from the sample set to load, from initiation of the pageview (e.g. click on a page link) to load completion in the browser. 
    /// </summary>
    public readonly Metric PageLoadTime = new Metric("ga:pageLoadTime", "Site Speed", "Total Page Load Time is the amount of time (in milliseconds) it takes for pages from the sample set to load, from initiation of the pageview (e.g. click on a page link) to load completion in the browser.");

    /// <summary>
    /// The sample set (or count) of pageviews used to calculate the average page load time.
    /// </summary>
    public readonly Metric PageLoadSample = new Metric("ga:pageLoadSample", "Site Speed", "The sample set (or count) of pageviews used to calculate the average page load time.");

    /// <summary>
    /// The total amount of time (in milliseconds) spent in DNS lookup for this page among all samples.
    /// </summary>
    public readonly Metric DomainLookupTime = new Metric("ga:domainLookupTime", "Site Speed", "The total amount of time (in milliseconds) spent in DNS lookup for this page among all samples.");

    /// <summary>
    /// The total amount of time (in milliseconds) to download this page among all samples.
    /// </summary>
    public readonly Metric PageDownloadTime = new Metric("ga:pageDownloadTime", "Site Speed", "The total amount of time (in milliseconds) to download this page among all samples.");

    /// <summary>
    /// The total amount of time (in milliseconds) spent in redirects before fetching this page among all samples. If there are no redirects, the value for this metric is expected to be 0.
    /// </summary>
    public readonly Metric RedirectionTime = new Metric("ga:redirectionTime", "Site Speed", "The total amount of time (in milliseconds) spent in redirects before fetching this page among all samples. If there are no redirects, the value for this metric is expected to be 0.");

    /// <summary>
    /// The total amount of time (in milliseconds) spent in establishing TCP connection for this page among all samples.
    /// </summary>
    public readonly Metric ServerConnectionTime = new Metric("ga:serverConnectionTime", "Site Speed", "The total amount of time (in milliseconds) spent in establishing TCP connection for this page among all samples.");

    /// <summary>
    /// The total amount of time (in milliseconds) your server takes to respond to a user request among all samples, including the network time from user's location to your server.
    /// </summary>
    public readonly Metric ServerResponseTime = new Metric("ga:serverResponseTime", "Site Speed", "The total amount of time (in milliseconds) your server takes to respond to a user request among all samples, including the network time from user's location to your server.");

    /// <summary>
    /// The sample set (or count) of pageviews used to calculate the averages for site speed metrics. This metric is used in all site speed average calculations including avgDomainLookupTime, avgPageDownloadTime, avgRedirectionTime, avgServerConnectionTime, and avgServerResponseTime.
    /// </summary>
    public readonly Metric SpeedMetricSample = new Metric("ga:speedMetricSample", "Site Speed", "The sample set (or count) of pageviews used to calculate the averages for site speed metrics. This metric is used in all site speed average calculations including avgDomainLookupTime, avgPageDownloadTime, avgRedirectionTime, avgServerConnectionTime, and avgServerResponseTime.");

    /// <summary>
    /// The time the browser takes (in milliseconds) to parse the document (DOMInteractive), including the network time from the user's location to your server. At this time, the user can interact with the Document Object Model even though it is not fully loaded.
    /// </summary>
    public readonly Metric DomInteractiveTime = new Metric("ga:domInteractiveTime", "Site Speed", "The time the browser takes (in milliseconds) to parse the document (DOMInteractive), including the network time from the user's location to your server. At this time, the user can interact with the Document Object Model even though it is not fully loaded.");

    /// <summary>
    /// The time the browser takes (in milliseconds) to parse the document and execute deferred and parser-inserted scripts (DOMContentLoaded), including the network time from the user's location to your server. Parsing of the document is finished, the Document Object Model is ready, but referenced style sheets, images, and subframes may not be finished loading. This event is often the starting point for javascript framework execution, e.g., JQuery's onready() callback, etc.
    /// </summary>
    public readonly Metric DomContentLoadedTime = new Metric("ga:domContentLoadedTime", "Site Speed", "The time the browser takes (in milliseconds) to parse the document and execute deferred and parser-inserted scripts (DOMContentLoaded), including the network time from the user's location to your server. Parsing of the document is finished, the Document Object Model is ready, but referenced style sheets, images, and subframes may not be finished loading. This event is often the starting point for javascript framework execution, e.g., JQuery's onready() callback, etc.");

    /// <summary>
    /// The sample set (or count) of pageviews used to calculate the averages for site speed DOM metrics. This metric is used in the avgDomContentLoadedTime and avgDomInteractiveTime calculations.
    /// </summary>
    public readonly Metric DomLatencyMetricsSample = new Metric("ga:domLatencyMetricsSample", "Site Speed", "The sample set (or count) of pageviews used to calculate the averages for site speed DOM metrics. This metric is used in the avgDomContentLoadedTime and avgDomInteractiveTime calculations.");

    /// <summary>
    /// The average amount of time (in seconds) it takes for pages from the sample set to load, from initiation of the pageview (e.g. click on a page link) to load completion in the browser.
    /// </summary>
    public readonly Metric AvgPageLoadTime = new Metric("ga:avgPageLoadTime", "Site Speed", "The average amount of time (in seconds) it takes for pages from the sample set to load, from initiation of the pageview (e.g. click on a page link) to load completion in the browser.");

    /// <summary>
    /// The average amount of time (in seconds) spent in DNS lookup for this page.
    /// </summary>
    public readonly Metric AvgDomainLookupTime = new Metric("ga:avgDomainLookupTime", "Site Speed", "The average amount of time (in seconds) spent in DNS lookup for this page.");

    /// <summary>
    /// The average amount of time (in seconds) to download this page. 
    /// </summary>

    /// <summary>
    /// The average amount of time (in seconds) spent in redirects before fetching this page. If there are no redirects, the value for this metric is expected to be 0.
    /// </summary>
    public readonly Metric AvgRedirectionTime = new Metric("ga:avgRedirectionTime", "Site Speed", "The average amount of time (in seconds) spent in redirects before fetching this page. If there are no redirects, the value for this metric is expected to be 0.");

    /// <summary>
    /// The average amount of time (in seconds) spent in establishing TCP connection for this page.
    /// </summary>
    public readonly Metric AvgServerConnectionTime = new Metric("ga:avgServerConnectionTime", "Site Speed", "The average amount of time (in seconds) spent in establishing TCP connection for this page.");

    /// <summary>
    /// The average amount of time (in seconds) your server takes to respond to a user request, including the network time from user's location to your server.
    /// </summary>
    public readonly Metric AvgServerResponseTime = new Metric("ga:avgServerResponseTime", "Site Speed", "The average amount of time (in seconds) your server takes to respond to a user request, including the network time from user's location to your server.");

    /// <summary>
    /// The average time (in seconds) it takes the browser to parse the document and execute deferred and parser-inserted scripts including the network time from the user's location to your server.
    /// </summary>
    public readonly Metric AvgDomInteractiveTime = new Metric("ga:avgDomInteractiveTime", "Site Speed", "The average time (in seconds) it takes the browser to parse the document and execute deferred and parser-inserted scripts including the network time from the user's location to your server.");

    /// <summary>
    /// The average time (in seconds) it takes the browser to parse the document.
    /// </summary>
    public readonly Metric AvgDomContentLoadedTime = new Metric("ga:avgDomContentLoadedTime", "Site Speed", "The average time (in seconds) it takes the browser to parse the document.");
  }
}
