namespace BlazorApp57.Pages;

public static class TempExtensions
{
    public static double ToFarenheit(this double celsius)
    {
        var converted = (celsius * 1.8) + 32;
        return Math.Round(converted, 1);
    }
}
