namespace Modeles;
public static class DateTimeExtentions
{
    // the following code is based on Refrencial Trasparancy

    public static IEnumerable<(int year, int month)> GetYearMonths(this DateTime time) =>
        //Enumerable.Range(1, 12).Select(month => (time.Year, month));
        time.Year.GetYearMonths();

    public static IEnumerable<(int year, int month)> GetYearMonths(this int year) =>
        Enumerable.Range(1, 12).Select(month => (year, month));

    public static IEnumerable<(int year, int month)> GetDecadeMonths(this DateTime time) =>
        //Enumerable.Empty<(int, int)>();
        Enumerable.Range(time.Year.ToDacadeBeginning(), 10).SelectMany(GetYearMonths);

    private static int ToDacadeBeginning(this int year) => year / 10 * 10 + 1;
}
