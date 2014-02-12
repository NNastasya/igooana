namespace Igooana.Metrics
{
  public class GoalConversions
  {
    internal GoalConversions() { }

    /// <summary>
    /// The total number of starts for the requested goal number.
    /// </summary>
    public readonly Metric GoalXXStarts = new Metric("ga:goalXXStarts", "Goal conversions", "The total number of starts for the requested goal number.");

    /// <summary>
    /// The total number of starts for all goals defined for your profile.
    /// </summary>
    public readonly Metric GoalStartsAll = new Metric("ga:goalStartsAll","Goal conversions",  "The total number of starts for all goals defined for your profile.");

    /// <summary>
    /// The total number of completions for the requested goal number.
    /// </summary>
    public readonly Metric GoalXXCompletions = new Metric("ga:goalXXCompletions","Goal conversions",  "The total number of completions for the requested goal number.");
    

    /// <summary>
    /// The total number of completions for all goals defined for your profile.
    /// </summary>
    public readonly Metric GoalCompletionsAll = new Metric("ga:goalCompletionsAll","Goal conversions",  "The total number of completions for all goals defined for your profile.");

    /// <summary>
    /// The total numeric value for the requested goal number.
    /// </summary>
    public readonly Metric GoalXXValue = new Metric("ga:goalXXValue", "Goal conversions", "The total numeric value for the requested goal number.");

    /// <summary>
    /// The total numeric value for all goals defined for your profile.
    /// </summary>
    public readonly Metric GoalValueAll = new Metric("ga:goalValueAll", "Goal conversions", "The total numeric value for all goals defined for your profile.");

    /// <summary>
    /// The average goal value of a visit to your property.
    /// </summary>
    public readonly Metric GoalValuePerVisit = new Metric("ga:goalValuePerVisit", "Goal conversions", "The average goal value of a visit to your property.");

    /// <summary>
    /// The percentage of visits which resulted in a conversion to the requested goal number.
    /// </summary>
    public readonly Metric GoalXXConversionRate = new Metric("ga:goalXXConversionRate", "Goal conversions", "The percentage of visits which resulted in a conversion to the requested goal number.");


    /// <summary>
    /// The percentage of visits which resulted in a conversion to at least one of your goals.
    /// </summary>
    public readonly Metric GoalConverstionRateAll = new Metric("ga:goalXXConversionRateAll", "Goal conversions", "The percentage of visits which resulted in a conversion to at least one of your goals.");

    /// <summary>
    /// The number of times visitors started conversion activity on the requested goal number without actually completing it.
    /// </summary>
    public readonly Metric GoalXXAbandons = new Metric("ga:goalXXAbandons", "Goal conversions", "The number of times visitors started conversion activity on the requested goal number without actually completing it.");

    /// <summary>
    /// The overall number of times visitors started goals without actually completing them.
    /// </summary>
    public readonly Metric GoalAbandonsAll = new Metric("ga:goalAbandonsAll", "Goal conversions", "The overall number of times visitors started goals without actually completing them.");

    /// <summary>
    /// The rate at which the requested goal number was abandoned.
    /// </summary>
    public readonly Metric GoalXXAbandonRate = new Metric("ga:goalXXAbandonRate", "Goal conversions", "The rate at which the requested goal number was abandoned.");

    /// <summary>
    /// The rate at which goals were abandoned.
    /// </summary>
    public readonly Metric GoalAbandonRateAll = new Metric("ga:goalAbandonRateAll", "Goal conversions", "The rate at which goals were abandoned.");
  }
}
