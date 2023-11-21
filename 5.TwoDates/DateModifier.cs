using System;

public class DateModifier
{
    public static void Main()
    {
        string date1 = "1992 05 31";
        string date2 = "2016 06 17";

        int difference = CalculateDateDifference(date1, date2);

        Console.WriteLine(difference);
    }

    public static int CalculateDateDifference(string dateString1, string dateString2)
    {
        DateTime date1 = DateTime.ParseExact(dateString1, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);
        DateTime date2 = DateTime.ParseExact(dateString2, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);

        TimeSpan difference = date2 - date1;

        return difference.Days;
    }
}
