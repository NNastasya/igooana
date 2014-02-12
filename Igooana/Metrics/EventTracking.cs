namespace Igooana.Metrics {
  public class EventTracking {
    internal EventTracking() { }

    /// <summary>
    /// The total number of events for the profile, across all categories.
    /// </summary>
    public readonly Metric TotalEvents = new Metric("ga:totalEvents", "Event Tracking", "The total number of events for the profile, across all categories.");

    /// <summary>
    /// The total number of unique events for the profile, across all categories.
    /// </summary>
    public readonly Metric UniqueEvents = new Metric("ga:uniqueEvents", "Event Tracking", "The total number of unique events for the profile, across all categories.");

    /// <summary>
    /// The total value of events for the profile.
    /// </summary>
    public readonly Metric EventValue = new Metric("ga:eventValue", "Event Tracking", "The total value of events for the profile.");

    /// <summary>
    /// The total number of visits with events.
    /// </summary>
    public readonly Metric VisitsWithEvent = new Metric("ga:visitsWithEvent", "Event Tracking", "The total number of visits with events.");

    /// <summary>
    /// The average value of an event.
    /// </summary>
    public readonly Metric AvgEventValue = new Metric("ga:avgEventValue", "Event Tracking", "The average value of an event.");

    /// <summary>
    /// The average number of events per visit with event.
    /// </summary>
    public readonly Metric EventsPerVisitWithEvent = new Metric("ga:eventsPerVisitWithEvent", "Event Tracking", "The average number of events per visit with event.");
  }
}
