using Models.Types;

namespace Modeles;

public static class DateTimeExtentions
{
    // Fuction that apply to a type 
    public static Year ToYear(this DateTime time) => new(time.Year);

    // the following code is based on Refrencial Trasparancy


    //************** moved to Year type
    //public static IEnumerable<Month> GetYearMonths(this DateTime time) =>
    //    //Enumerable.Range(1, 12).Select(month => (time.Year, month));
    //    time.Year.GetYearMonths();

    //public static IEnumerable<Month> GetYearMonths(this int year) =>
    //    Enumerable.Range(1, 12).Select(month => new Month(new(year), month));

    //public static IEnumerable<Month> GetDecadeMonths(this DateTime time) =>
    //    //Enumerable.Empty<(int, int)>();
    //    Enumerable.Range(time.Year.ToDacadeBeginning(), 10).SelectMany(GetYearMonths);

    //private static int ToDacadeBeginning(this int year) => year / 10 * 10 + 1;
}
