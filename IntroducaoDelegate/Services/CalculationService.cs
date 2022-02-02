namespace IntroducaoDelegate.Services;
internal class CalculationService
{
    #region Exemplo01
    public static double Max(double x, double y)
    {
        return (x > y) ? x : y;
    }
    public static double Sum(double x, double y)
    {
        return x + y;
    }
    public static double Square(double x)
    {
        return x * x;
    }
    #endregion

    #region Exemplo02
    public static void ShowMax(double x, double y)
    {
        double max = (x < y) ? y : x;
        Console.WriteLine(max);
    }

    public static void ShowSum(double x, double y)
    {
        double sum = x + y;
        Console.WriteLine(sum);
    }
    #endregion
}