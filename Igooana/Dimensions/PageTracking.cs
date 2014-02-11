namespace Igooana.Dimensions {
  public  class PageTracking {
    internal PageTracking() { }
    /// <summary>
    /// A page on your website specified by path and/or query parameters. Use in conjunction with hostname to get the full URL of the page.
    /// </summary>
    public readonly Dimension PagePath = new Dimension("ga:pagepath", "Page Tracking", "A page on your website specified by path and/or query parameters. Use in conjunction with hostname to get the full URL of the page.");
  }
}
