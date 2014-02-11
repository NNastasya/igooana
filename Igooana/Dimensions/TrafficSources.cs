using System;

namespace Igooana.Dimensions {
  public class TrafficSources {
    internal TrafficSources() { }
    /// <summary>
    /// The source of referrals to your property. When using manual campaign tracking, the value of the utm_source campaign tracking parameter. When using AdWords autotagging, the value is google. Otherwise the domain of the source referring the visitor to your property (e.g. document.referrer). The value may also contain a port address. If the visitor arrived without a referrer, the value is (direct) 
    /// </summary>
    public readonly Dimension Source = new Dimension("ga:source", "Traffic Sources", "The source of referrals to your property. When using manual campaign tracking, the value of the utm_source campaign tracking parameter. When using AdWords autotagging, the value is google. Otherwise the domain of the source referring the visitor to your property (e.g. document.referrer). The value may also contain a port address. If the visitor arrived without a referrer, the value is (direct)");
  }
}
