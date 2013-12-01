using System;

namespace Igooana {
  public class Profile {
    public int Id { get; set; }
    public int AccountId { get; set; }
    public string WebPropertyId { get; set; }
    public string Name { get; set; }
    public string Currency { get; set; }
    public string WebSiteUrl { get; set; }
    public DateTime CreatedAt { get; set; }
  }
}
