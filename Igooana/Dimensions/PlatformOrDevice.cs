using System;

namespace Igooana.Dimensions {
  public  class PlatformOrDevice {
    internal PlatformOrDevice() { }
    /// <summary>
    /// The names of browsers used by visitors to your website. For example, Internet Explorer or Firefox.
    /// </summary>
    public readonly Dimension Browser = new Dimension("ga:browser", "Platform or Device", "The names of browsers used by visitors to your website. For example, Internet Explorer or Firefox.");
  }
}
