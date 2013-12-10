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
