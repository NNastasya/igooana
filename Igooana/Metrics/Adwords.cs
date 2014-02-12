namespace Igooana.Metrics {
  public class Adwords {
    internal Adwords() { }

    /// <summary>
    /// Total number of campaign impressions. 
    /// </summary>
    public readonly Metric Impressions = new Metric("ga:impressions", "Adwords", "Total number of campaign impressions.");

    /// <summary>
    /// The total number of times users have clicked on an ad to reach your property. 
    /// </summary>
    public readonly Metric AdClicks = new Metric("ga:adClicks", "Adwords", "The total number of times users have clicked on an ad to reach your property.");

    /// <summary>
    /// Derived cost for the advertising campaign. The currency for this value is based on the currency that you set in your AdWords account. 
    /// </summary>
    public readonly Metric AdCost = new Metric("ga:adCost", "Adwords", "Derived cost for the advertising campaign. The currency for this value is based on the currency that you set in your AdWords account.");

    /// <summary>
    /// Cost per thousand impressions. 
    /// </summary>
    public readonly Metric CPM = new Metric("ga:CPM", "Adwords", "Cost per thousand impressions.");

    /// <summary>
    /// Cost to advertiser per click. 
    /// </summary>
    public readonly Metric CPC = new Metric("ga:CPC", "Adwords", "Cost to advertiser per click.");

    /// <summary>
    /// Click-through-rate for your ad. This is equal to the number of clicks divided by the number of impressions for your ad (e.g. how many times users clicked on one of your ads where that ad appeared).
    /// </summary>
    public readonly Metric CTR = new Metric("ga:CTR", "Adwords", "Click-through-rate for your ad. This is equal to the number of clicks divided by the number of impressions for your ad (e.g. how many times users clicked on one of your ads where that ad appeared).");

    /// <summary>
    /// The cost per transaction for your property.
    /// </summary>
    public readonly Metric CostPerTransaction = new Metric("ga:costPerTransaction", "Adwords", "The cost per transaction for your property.");

    /// <summary>
    /// The cost per goal conversion for your property.
    /// </summary>
    public readonly Metric CostPerGoalConversion = new Metric("ga:costPerGoalConversion", "Adwords", "The cost per goal conversion for your property.");

    /// <summary>
    /// The cost per conversion (including ecommerce and goal conversions) for your property.
    /// </summary>
    public readonly Metric CostPerConversion = new Metric("ga:costPerConversion", "Adwords", "The cost per conversion (including ecommerce and goal conversions) for your property.");

    /// <summary>
    /// RPC or revenue-per-click is the average revenue (from ecommerce sales and/or goal value) you received for each click on one of your search ads.
    /// </summary>
    public readonly Metric PRC = new Metric("ga:RPC", "Adwords", "RPC or revenue-per-click is the average revenue (from ecommerce sales and/or goal value) you received for each click on one of your search ads.");

    /// <summary>
    /// Returns on Investment is overall transaction profit divided by derived advertising cost.
    /// </summary>
    public readonly Metric ROI = new Metric("ga:ROI", "Adwords", "Returns on Investment is overall transaction profit divided by derived advertising cost.");

    /// <summary>
    /// The overall transaction profit margin.
    /// </summary>
    public readonly Metric Margin = new Metric("ga:margin", "Adwords", "The overall transaction profit margin.");

  }
}
