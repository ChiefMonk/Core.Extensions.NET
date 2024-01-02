namespace Core.Extensions.NET;

public static class DateTimeExtensions
{
	/// <summary>
	/// Retrieves the first day of the month of the <paramref name="date"/>.
	/// </summary>
	/// <param name="date">A date from the month we want to get the first day.</param>
	/// <returns>A DateTime representing the first day of the month.</returns>
	public static DateTime FirstDayOfTheMonth(this DateTime date)
	{
		return new DateTime(date.Year, date.Month, 1);
	}

	/// <summary>
	/// Retrieves the last day of the month of the <paramref name="date"/>.
	/// </summary>
	/// <param name="date">A date from the month we want to get the last day.</param>
	/// <returns>A DateTime representing the last day of the month.</returns>
	public static DateTime LastDayOfTheMonth(this DateTime date)
	{
		return new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
	}
}