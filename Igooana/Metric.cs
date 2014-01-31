using System;
using Igooana.Extensions;

namespace Igooana {
  public class Metric {

    #region Fields

    private readonly string metricString;
    private string category;
    private string description;
    public static readonly Metric Empty = new EmptyMetric();

    #region Visitor

    /// <summary>
    /// Total number of visitors to your property for the requested time period.
    /// </summary>
    public static readonly Metric Visitors = new Metric("ga:visitors", "Visitor", "Total number of visitors to your property for the requested time period.");
    
    /// <summary>
    /// The number of visitors whose visit to your property was marked as a first-time visit. 
    /// </summary>
    public static readonly Metric NewVisits = new Metric("ga:newVisits", "Visitor", "The number of visitors whose visit to your property was marked as a first-time visit.");

    /// <summary>
    /// The percentage of visits by people who had never visited your property before.
    /// </summary>
    public static readonly Metric PercentNewVisits = new Metric("ga:percentNewVisits", "Visitor", "The percentage of visits by people who had never visited your property before.");

    #endregion

    #region Session

    /// <summary>
    /// Counts the total number of sessions.
    /// </summary>
    public static readonly Metric Visits = new Metric("ga:visits", "Session", "Counts the total number of sessions.");

    /// <summary>
    /// The total number of single page (or single engagement hit) sessions for your property. 
    /// </summary>
    public static readonly Metric Bounces = new Metric("ga:bounces", "Session", "The total number of single page (or single engagement hit) sessions for your property.");

    /// <summary>
    /// The percentage of single-page visits (i.e. visits in which the person left your property from the entrance page). 
    /// </summary>
    public static readonly Metric EntranceBounceRate = new Metric("ga:entranceBounceRate", "Session", "The percentage of single-page visits (i.e. visits in which the person left your property from the entrance page).");
    
    /// <summary>
    /// The percentage of single-page visits (i.e., visits in which the person left your property from the first page). 
    /// </summary>
    public static readonly Metric VisitBounceRate = new Metric("ga:visitBounceRate", "Session", "The percentage of single-page visits (i.e., visits in which the person left your property from the first page).");

    /// <summary>
    /// The total duration of visitor sessions represented in total seconds. 
    /// </summary>
    public static readonly Metric TimeOnSite = new Metric("ga:timeOnSite", "Session", "The total duration of visitor sessions represented in total seconds.");

    /// <summary>
    /// The average duration visitor sessions represented in total seconds. 
    /// </summary>
    public static readonly Metric AvgTimeOnSite = new Metric("ga:avgTimeOnSite", "Session", "The average duration visitor sessions represented in total seconds.");

    #endregion

    #region Traffic sources

    /// <summary>
    /// The average duration visitor sessions represented in total seconds. 
    /// </summary>
    public static readonly Metric OrganicSearches = new Metric("ga:organicSearches", "Traffic sources", "The number of organic searches that happened within a session. This metric is search engine agnostic.");

    #endregion

    #region Adwords

    /// <summary>
    /// Total number of campaign impressions. 
    /// </summary>
    public static readonly Metric Impressions = new Metric("ga:impressions", "Adwords", "Total number of campaign impressions.");

    /// <summary>
    /// The total number of times users have clicked on an ad to reach your property. 
    /// </summary>
    public static readonly Metric AdClicks = new Metric("ga:adClicks", "Adwords", "The total number of times users have clicked on an ad to reach your property.");

    /// <summary>
    /// Derived cost for the advertising campaign. The currency for this value is based on the currency that you set in your AdWords account. 
    /// </summary>
    public static readonly Metric AdCost = new Metric("ga:adCost", "Adwords", "Derived cost for the advertising campaign. The currency for this value is based on the currency that you set in your AdWords account.");

    /// <summary>
    /// Cost per thousand impressions. 
    /// </summary>
    public static readonly Metric CPM = new Metric("ga:CPM", "Adwords", "Cost per thousand impressions.");

    /// <summary>
    /// Cost to advertiser per click. 
    /// </summary>
    public static readonly Metric CPC = new Metric("ga:CPC", "Adwords", "Cost to advertiser per click.");

    /// <summary>
    /// Click-through-rate for your ad. This is equal to the number of clicks divided by the number of impressions for your ad (e.g. how many times users clicked on one of your ads where that ad appeared).
    /// </summary>
    public static readonly Metric CTR = new Metric("ga:CTR", "Adwords", "Click-through-rate for your ad. This is equal to the number of clicks divided by the number of impressions for your ad (e.g. how many times users clicked on one of your ads where that ad appeared).");

    /// <summary>
    /// The cost per transaction for your property.
    /// </summary>
    public static readonly Metric CostPerTransaction = new Metric("ga:costPerTransaction", "Adwords", "The cost per transaction for your property.");

    /// <summary>
    /// The cost per goal conversion for your property.
    /// </summary>
    public static readonly Metric CostPerGoalConversion = new Metric("ga:costPerGoalConversion", "Adwords", "The cost per goal conversion for your property.");

    /// <summary>
    /// The cost per conversion (including ecommerce and goal conversions) for your property.
    /// </summary>
    public static readonly Metric CostPerConversion = new Metric("ga:costPerConversion", "Adwords", "The cost per conversion (including ecommerce and goal conversions) for your property.");

    /// <summary>
    /// RPC or revenue-per-click is the average revenue (from ecommerce sales and/or goal value) you received for each click on one of your search ads.
    /// </summary>
    public static readonly Metric PRC = new Metric("ga:RPC", "Adwords", "RPC or revenue-per-click is the average revenue (from ecommerce sales and/or goal value) you received for each click on one of your search ads.");

    /// <summary>
    /// Returns on Investment is overall transaction profit divided by derived advertising cost.
    /// </summary>
    public static readonly Metric ROI = new Metric("ga:ROI", "Adwords", "Returns on Investment is overall transaction profit divided by derived advertising cost.");

    /// <summary>
    /// The overall transaction profit margin.
    /// </summary>
    public static readonly Metric Margin = new Metric("ga:margin", "Adwords", "The overall transaction profit margin.");

    #endregion

    #region Goal conversions

    /// <summary>
    /// The total number of starts for the requested goal number.
    /// </summary>
    public static readonly Metric GoalXXStarts = new Metric("ga:goalXXStarts", "Goal conversions", "The total number of starts for the requested goal number.");

    /// <summary>
    /// The total number of starts for all goals defined for your profile.
    /// </summary>
    public static readonly Metric GoalStartsAll = new Metric("ga:goalStartsAll","Goal conversions",  "The total number of starts for all goals defined for your profile.");

    /// <summary>
    /// The total number of completions for the requested goal number.
    /// </summary>
    public static readonly Metric GoalXXCompletions = new Metric("ga:goalXXCompletions","Goal conversions",  "The total number of completions for the requested goal number.");
    

    /// <summary>
    /// The total number of completions for all goals defined for your profile.
    /// </summary>
    public static readonly Metric GoalCompletionsAll = new Metric("ga:goalCompletionsAll","Goal conversions",  "The total number of completions for all goals defined for your profile.");

    /// <summary>
    /// The total numeric value for the requested goal number.
    /// </summary>
    public static readonly Metric GoalXXValue = new Metric("ga:goalXXValue", "Goal conversions", "The total numeric value for the requested goal number.");

    /// <summary>
    /// The total numeric value for all goals defined for your profile.
    /// </summary>
    public static readonly Metric GoalValueAll = new Metric("ga:goalValueAll", "Goal conversions", "The total numeric value for all goals defined for your profile.");

    /// <summary>
    /// The average goal value of a visit to your property.
    /// </summary>
    public static readonly Metric GoalValuePerVisit = new Metric("ga:goalValuePerVisit", "Goal conversions", "The average goal value of a visit to your property.");

    /// <summary>
    /// The percentage of visits which resulted in a conversion to the requested goal number.
    /// </summary>
    public static readonly Metric GoalXXConversionRate = new Metric("ga:goalXXConversionRate", "Goal conversions", "The percentage of visits which resulted in a conversion to the requested goal number.");


    /// <summary>
    /// The percentage of visits which resulted in a conversion to at least one of your goals.
    /// </summary>
    public static readonly Metric GoalConverstionRateAll = new Metric("ga:goalXXConversionRateAll", "Goal conversions", "The percentage of visits which resulted in a conversion to at least one of your goals.");

    /// <summary>
    /// The number of times visitors started conversion activity on the requested goal number without actually completing it.
    /// </summary>
    public static readonly Metric GoalXXAbandons = new Metric("ga:goalXXAbandons", "Goal conversions", "The number of times visitors started conversion activity on the requested goal number without actually completing it.");

    /// <summary>
    /// The overall number of times visitors started goals without actually completing them.
    /// </summary>
    public static readonly Metric GoalAbandonsAll = new Metric("ga:goalAbandonsAll", "Goal conversions", "The overall number of times visitors started goals without actually completing them.");

    /// <summary>
    /// The rate at which the requested goal number was abandoned.
    /// </summary>
    public static readonly Metric GoalXXAbandonRate = new Metric("ga:goalXXAbandonRate", "Goal conversions", "The rate at which the requested goal number was abandoned.");

    /// <summary>
    /// The rate at which goals were abandoned.
    /// </summary>
    public static readonly Metric GoalAbandonRateAll = new Metric("ga:goalAbandonRateAll", "Goal conversions", "The rate at which goals were abandoned.");

    #endregion

    #region Social Activities

    /// <summary>
    /// The count of activities where a content URL was shared / mentioned on a social data hub partner network.
    /// </summary>
    public static readonly Metric SocialActivities = new Metric("ga:socialActivities", "SocialActivities", "The count of activities where a content URL was shared / mentioned on a social data hub partner network.");

    #endregion

    #region Page Tracking

    /// <summary>
    /// The average value of this page or set of pages. Page Value is (ga:transactionRevenue + ga:goalValueAll) / ga:uniquePageviews (for the page or set of pages).
    /// </summary>
    public static readonly Metric PageValue = new Metric("ga:pageValue", "Page tracking", "The average value of this page or set of pages. Page Value is (ga:transactionRevenue + ga:goalValueAll) / ga:uniquePageviews (for the page or set of pages).");

    /// <summary>
    /// The number of entrances to your property measured as the first pageview in a session. Typically used with landingPagePath
    /// </summary>
    public static readonly Metric Entrances = new Metric("ga:entrances", "Page tracking", "The number of entrances to your property measured as the first pageview in a session. Typically used with landingPagePath");

    /// <summary>
    /// The total number of pageviews for your property.
    /// </summary>
    public static readonly Metric PageViews = new Metric("ga:pageviews", "Page tracking", "The total number of pageviews for your property.");

    /// <summary>
    /// The number of different (unique) pages within a session. This takes into both the pagePath and pageTitle to determine uniqueness.
    /// </summary>
    public static readonly Metric UniquePageViews = new Metric("ga:uniquePageviews", "Page tracking", "The number of different (unique) pages within a session. This takes into both the pagePath and pageTitle to determine uniqueness.");

    /// <summary>
    /// How long a visitor spent on a particular page in seconds. Calculated by subtracting the initial view time for a particular page from the initial view time for a subsequent page. Thus, this metric does not apply to exit pages for your property.
    /// </summary>
    public static readonly Metric TimeOnPage = new Metric("ga:timeOnPage", "Page tracking", "How long a visitor spent on a particular page in seconds. Calculated by subtracting the initial view time for a particular page from the initial view time for a subsequent page. Thus, this metric does not apply to exit pages for your property.");

    /// <summary>
    /// The number of exits from your property.
    /// </summary>
    public static readonly Metric Exits = new Metric("ga:exits", "Page tracking", "The number of exits from your property.");

    /// <summary>
    /// The percentage of pageviews in which this page was the entrance.
    /// </summary>
    public static readonly Metric EntranceRate = new Metric("ga:entranceRate", "Page tracking", "The percentage of pageviews in which this page was the entrance.");

    /// <summary>
    /// The average number of pages viewed during a visit to your property. Repeated views of a single page are counted.
    /// </summary>
    public static readonly Metric PageviewsPerVisit = new Metric("ga:pageviewsPerVisit", "Page tracking", "The average number of pages viewed during a visit to your property. Repeated views of a single page are counted.");

    /// <summary>
    /// The average amount of time visitors spent viewing this page or a set of pages.
    /// </summary>
    public static readonly Metric AvgTimeOnPage = new Metric("ga:avgTimeOnPage", "Page tracking", "The average amount of time visitors spent viewing this page or a set of pages.");

    /// <summary>
    /// The percentage of exits from your property that occurred out of the total page views.
    /// </summary>
    public static readonly Metric ExitRate = new Metric("ga:exitRate", "Page tracking", "The percentage of exits from your property that occurred out of the total page views.");

    #endregion

    #region Site Speed

    /// <summary>
    /// Total Page Load Time is the amount of time (in milliseconds) it takes for pages from the sample set to load, from initiation of the pageview (e.g. click on a page link) to load completion in the browser. 
    /// </summary>
    public static readonly Metric PageLoadTime = new Metric("ga:pageLoadTime", "Site Speed", "Total Page Load Time is the amount of time (in milliseconds) it takes for pages from the sample set to load, from initiation of the pageview (e.g. click on a page link) to load completion in the browser.");

    /// <summary>
    /// The sample set (or count) of pageviews used to calculate the average page load time.
    /// </summary>
    public static readonly Metric PageLoadSample = new Metric("ga:pageLoadSample", "Site Speed", "The sample set (or count) of pageviews used to calculate the average page load time.");
    
    /// <summary>
    /// The total amount of time (in milliseconds) spent in DNS lookup for this page among all samples.
    /// </summary>
    public static readonly Metric DomainLookupTime = new Metric("ga:domainLookupTime", "Site Speed", "The total amount of time (in milliseconds) spent in DNS lookup for this page among all samples.");

    /// <summary>
    /// The total amount of time (in milliseconds) to download this page among all samples.
    /// </summary>
    public static readonly Metric PageDownloadTime = new Metric("ga:pageDownloadTime", "Site Speed", "The total amount of time (in milliseconds) to download this page among all samples.");
    
    /// <summary>
    /// The total amount of time (in milliseconds) spent in redirects before fetching this page among all samples. If there are no redirects, the value for this metric is expected to be 0.
    /// </summary>
    public static readonly Metric RedirectionTime = new Metric("ga:redirectionTime", "Site Speed", "The total amount of time (in milliseconds) spent in redirects before fetching this page among all samples. If there are no redirects, the value for this metric is expected to be 0.");

    /// <summary>
    /// The total amount of time (in milliseconds) spent in establishing TCP connection for this page among all samples.
    /// </summary>
    public static readonly Metric ServerConnectionTime = new Metric("ga:serverConnectionTime", "Site Speed", "The total amount of time (in milliseconds) spent in establishing TCP connection for this page among all samples.");

    /// <summary>
    /// The total amount of time (in milliseconds) your server takes to respond to a user request among all samples, including the network time from user's location to your server.
    /// </summary>
    public static readonly Metric ServerResponseTime = new Metric("ga:serverResponseTime", "Site Speed", "The total amount of time (in milliseconds) your server takes to respond to a user request among all samples, including the network time from user's location to your server.");

    /// <summary>
    /// The sample set (or count) of pageviews used to calculate the averages for site speed metrics. This metric is used in all site speed average calculations including avgDomainLookupTime, avgPageDownloadTime, avgRedirectionTime, avgServerConnectionTime, and avgServerResponseTime.
    /// </summary>
    public static readonly Metric SpeedMetricSample = new Metric("ga:speedMetricSample", "Site Speed", "The sample set (or count) of pageviews used to calculate the averages for site speed metrics. This metric is used in all site speed average calculations including avgDomainLookupTime, avgPageDownloadTime, avgRedirectionTime, avgServerConnectionTime, and avgServerResponseTime.");

    /// <summary>
    /// The time the browser takes (in milliseconds) to parse the document (DOMInteractive), including the network time from the user's location to your server. At this time, the user can interact with the Document Object Model even though it is not fully loaded.
    /// </summary>
    public static readonly Metric DomInteractiveTime = new Metric("ga:domInteractiveTime", "Site Speed", "The time the browser takes (in milliseconds) to parse the document (DOMInteractive), including the network time from the user's location to your server. At this time, the user can interact with the Document Object Model even though it is not fully loaded.");

    /// <summary>
    /// The time the browser takes (in milliseconds) to parse the document and execute deferred and parser-inserted scripts (DOMContentLoaded), including the network time from the user's location to your server. Parsing of the document is finished, the Document Object Model is ready, but referenced style sheets, images, and subframes may not be finished loading. This event is often the starting point for javascript framework execution, e.g., JQuery's onready() callback, etc.
    /// </summary>
    public static readonly Metric DomContentLoadedTime = new Metric("ga:domContentLoadedTime", "Site Speed", "The time the browser takes (in milliseconds) to parse the document and execute deferred and parser-inserted scripts (DOMContentLoaded), including the network time from the user's location to your server. Parsing of the document is finished, the Document Object Model is ready, but referenced style sheets, images, and subframes may not be finished loading. This event is often the starting point for javascript framework execution, e.g., JQuery's onready() callback, etc.");

    /// <summary>
    /// The sample set (or count) of pageviews used to calculate the averages for site speed DOM metrics. This metric is used in the avgDomContentLoadedTime and avgDomInteractiveTime calculations.
    /// </summary>
    public static readonly Metric DomLatencyMetricsSample = new Metric("ga:domLatencyMetricsSample", "Site Speed", "The sample set (or count) of pageviews used to calculate the averages for site speed DOM metrics. This metric is used in the avgDomContentLoadedTime and avgDomInteractiveTime calculations.");

    /// <summary>
    /// The average amount of time (in seconds) it takes for pages from the sample set to load, from initiation of the pageview (e.g. click on a page link) to load completion in the browser.
    /// </summary>
    public static readonly Metric AvgPageLoadTime = new Metric("ga:avgPageLoadTime", "Site Speed", "The average amount of time (in seconds) it takes for pages from the sample set to load, from initiation of the pageview (e.g. click on a page link) to load completion in the browser.");

    /// <summary>
    /// The average amount of time (in seconds) spent in DNS lookup for this page.
    /// </summary>
    public static readonly Metric AvgDomainLookupTime = new Metric("ga:avgDomainLookupTime", "Site Speed", "The average amount of time (in seconds) spent in DNS lookup for this page.");

    /// <summary>
    /// The average amount of time (in seconds) to download this page. 
    /// </summary>

    /// <summary>
    /// The average amount of time (in seconds) spent in redirects before fetching this page. If there are no redirects, the value for this metric is expected to be 0.
    /// </summary>
    public static readonly Metric AvgRedirectionTime = new Metric("ga:avgRedirectionTime", "Site Speed", "The average amount of time (in seconds) spent in redirects before fetching this page. If there are no redirects, the value for this metric is expected to be 0.");

    /// <summary>
    /// The average amount of time (in seconds) spent in establishing TCP connection for this page.
    /// </summary>
    public static readonly Metric AvgServerConnectionTime = new Metric("ga:avgServerConnectionTime", "Site Speed", "The average amount of time (in seconds) spent in establishing TCP connection for this page.");

    /// <summary>
    /// The average amount of time (in seconds) your server takes to respond to a user request, including the network time from user's location to your server.
    /// </summary>
    public static readonly Metric AvgServerResponseTime = new Metric("ga:avgServerResponseTime", "Site Speed", "The average amount of time (in seconds) your server takes to respond to a user request, including the network time from user's location to your server.");

    /// <summary>
    /// The average time (in seconds) it takes the browser to parse the document and execute deferred and parser-inserted scripts including the network time from the user's location to your server.
    /// </summary>
    public static readonly Metric AvgDomInteractiveTime = new Metric("ga:avgDomInteractiveTime", "Site Speed", "The average time (in seconds) it takes the browser to parse the document and execute deferred and parser-inserted scripts including the network time from the user's location to your server.");

    /// <summary>
    /// The average time (in seconds) it takes the browser to parse the document.
    /// </summary>
    public static readonly Metric AvgDomContentLoadedTime = new Metric("ga:avgDomContentLoadedTime", "Site Speed", "The average time (in seconds) it takes the browser to parse the document.");

    #endregion

    #region App Tracking

    /// <summary>
    /// The total number of screenviews.
    /// </summary>
    public static readonly Metric ScreenViews = new Metric("ga:screenViews", "App Tracking", "The total number of screenviews.");

    /// <summary>
    /// The number of different (unique) screenviews within a session.
    /// </summary>
    public static readonly Metric UniqueScreenViews = new Metric("ga:uniqueScreenViews", "App Tracking", "The number of different (unique) screenviews within a session.");

    /// <summary>
    /// The time spent viewing the current screen.
    /// </summary>
    public static readonly Metric TimeOnScreen = new Metric("ga:timeOnScreen", "App Tracking", "The time spent viewing the current screen.");

    /// <summary>
    /// The average amount of time users spent on a screen in seconds.
    /// </summary>
    public static readonly Metric AvgScreenviewDuration = new Metric("ga:avgScreenviewDuration", "App Tracking", "The average amount of time users spent on a screen in seconds.");

    /// <summary>
    /// The average number of screenviews per session.
    /// </summary>
    public static readonly Metric ScreenviewsPerSession = new Metric("ga:screenviewsPerSession", "App Tracking", "The average number of screenviews per session.");

    #endregion

    #region Event Tracking

    /// <summary>
    /// The total number of events for the profile, across all categories.
    /// </summary>
    public static readonly Metric TotalEvents = new Metric("ga:totalEvents", "Event Tracking", "The total number of events for the profile, across all categories.");

    /// <summary>
    /// The total number of unique events for the profile, across all categories.
    /// </summary>
    public static readonly Metric UniqueEvents = new Metric("ga:uniqueEvents", "Event Tracking", "The total number of unique events for the profile, across all categories.");

    /// <summary>
    /// The total value of events for the profile.
    /// </summary>
    public static readonly Metric EventValue = new Metric("ga:eventValue", "Event Tracking", "The total value of events for the profile.");

    /// <summary>
    /// The total number of visits with events.
    /// </summary>
    public static readonly Metric VisitsWithEvent = new Metric("ga:visitsWithEvent", "Event Tracking", "The total number of visits with events.");

    /// <summary>
    /// The average value of an event.
    /// </summary>
    public static readonly Metric AvgEventValue = new Metric("ga:avgEventValue", "Event Tracking", "The average value of an event.");

    /// <summary>
    /// The average number of events per visit with event.
    /// </summary>
    public static readonly Metric EventsPerVisitWithEvent = new Metric("ga:eventsPerVisitWithEvent", "Event Tracking", "The average number of events per visit with event.");

    #endregion

    #endregion

    #region Ctor

    protected Metric(string metricString, string category = null, string description = null) {
      this.metricString = metricString;
      this.category = category;
      this.description = description;
    }

    #endregion

    #region Properties

    public string Category { get { return category; } }
    public string Description { get { return description; } }

    public bool IsEmpty {
      get {
        return String.IsNullOrEmpty(metricString);
      }
    }

    public virtual string UrlSeparator {
      get { return ","; }
    }

    #endregion

    public static Metric operator +(Metric m1, Metric m2) {
      Ensure.ArgumentNotNull(m1, "m1");
      Ensure.ArgumentNotNull(m2, "m2");
      return m1.Add(m2);
    }

    public Metric Add(Metric other) {
      if (object.ReferenceEquals(this, other)) {
        throw new InvalidOperationException("Addition must use two different metric instances");
      }
      // TODO: write tests for this
      return new Metric("{0}{1}{2}".FormatWith(metricString, UrlSeparator, other.metricString));
    }


    public override string ToString() {
      return metricString.UrlEncoded();
    }

    public class EmptyMetric : Metric {
      internal EmptyMetric() : base("") { }

      public override string UrlSeparator {
        get {
          return String.Empty;
        }
      }

    }
  }
}
