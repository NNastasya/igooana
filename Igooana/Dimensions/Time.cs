namespace Igooana.Dimensions {
  public class Time {
    internal Time() { }

    /// <summary>
    /// The date of the visit
    /// </summary>
    public  readonly Dimension Date = new Dimension("ga:date", "Time", "The date of the visit");

    /// <summary>
    /// The year of the visit. A four-digit year from 2005 to the current year.
    /// </summary>
    public readonly Dimension Year = new Dimension("ga:year", "Time", "The year of the visit. A four-digit year from 2005 to the current year.");

    /// <summary>
    /// The month of the visit. A two digit integer from 01 to 12.
    /// </summary>
    public readonly Dimension Month = new Dimension("ga:month", "Time", "The month of the visit. A two digit integer from 01 to 12.");

    /// <summary>
    /// The week of the visit. A two-digit number from 01 to 53. Each week starts on Sunday.
    /// </summary>
    public readonly Dimension Week = new Dimension("ga:week", "Time", "The week of the visit. A two-digit number from 01 to 53. Each week starts on Sunday.");

    /// <summary>
    /// The day of the month. A two-digit number from 01 to 31.
    /// </summary>
    public readonly Dimension Day = new Dimension("ga:day", "Time", "The day of the month. A two-digit number from 01 to 31.");

    /// <summary>
    /// A two-digit hour of the day ranging from 00-23 in the timezone configured for the account. This value is also corrected for daylight savings time, adhering to all local rules for daylight savings time. If your timezone follows daylight savings time, there will be an apparent bump in the number of visits during the change-over hour (e.g. between 1:00 and 2:00) for the day per year when that hour repeats. A corresponding hour with zero visits will occur at the opposite changeover. (Google Analytics does not track visitor time more precisely than hours.)
    /// </summary>
    public readonly Dimension Hour = new Dimension("ga:hour", "Time", "A two-digit hour of the day ranging from 00-23 in the timezone configured for the account. This value is also corrected for daylight savings time, adhering to all local rules for daylight savings time. If your timezone follows daylight savings time, there will be an apparent bump in the number of visits during the change-over hour (e.g. between 1:00 and 2:00) for the day per year when that hour repeats. A corresponding hour with zero visits will occur at the opposite changeover. (Google Analytics does not track visitor time more precisely than hours.)");

    /// <summary>
    /// Returns the minute in the hour. The possible values are between 00 and 59.
    /// </summary>
    public readonly Dimension Minute = new Dimension("ga:minute", "Time", "Returns the minute in the hour. The possible values are between 00 and 59.");

    /// <summary>
    /// Index for each month in the specified date range. Index for the first month in the date range is 0, 1 for the second month, and so on. The index corresponds to month entries.
    /// </summary>
    public readonly Dimension NthMonth = new Dimension("ga:nthMonth", "Time", "Index for each month in the specified date range. Index for the first month in the date range is 0, 1 for the second month, and so on. The index corresponds to month entries.");

    /// <summary>
    /// Index for each week in the specified date range. Index for the first week in the date range is 0, 1 for the second week, and so on. The index corresponds to week entries.
    /// </summary>
    public readonly Dimension NthWeek = new Dimension("ga:nthWeek", "Time", "Index for each week in the specified date range. Index for the first week in the date range is 0, 1 for the second week, and so on. The index corresponds to week entries.");

    /// <summary>
    /// Index for each day in the specified date range. Index for the first day (i.e., start-date) in the date range is 0, 1 for the second day, and so on.
    /// </summary>
    public readonly Dimension NthDay = new Dimension("ga:nthDay", "Time", "Index for each day in the specified date range. Index for the first day (i.e., start-date) in the date range is 0, 1 for the second day, and so on.");

    /// <summary>
    /// Index for each minute in the specified date range. Index for the first minute of first day (i.e., start-date) in the date range is 0, 1 for the next minute, and so on.
    /// </summary>
    public readonly Dimension NthMinute = new Dimension("ga:nthMinute", "Time", "Index for each minute in the specified date range. Index for the first minute of first day (i.e., start-date) in the date range is 0, 1 for the next minute, and so on.");

    /// <summary>
    /// The day of the week. A one-digit number from 0 (Sunday) to 6 (Saturday).
    /// </summary>
    public readonly Dimension DayOfWeek = new Dimension("ga:dayOfWeek", "Time", "The day of the week. A one-digit number from 0 (Sunday) to 6 (Saturday).");

    /// <summary>
    /// The name of the day of the week (in English).
    /// </summary>
    public readonly Dimension DayOfWeekName = new Dimension("ga:dayOfWeekName", "Time", "The name of the day of the week (in English).");

    /// <summary>
    /// Combined values of ga:date and ga:hour.
    /// </summary>
    public readonly Dimension DateHour = new Dimension("ga:dateHour", "Time", "Combined values of ga:date and ga:hour.");

    //TODO: more dimensions from this category
  }
}
