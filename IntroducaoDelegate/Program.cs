using IntroducaoDelegate.Services;

namespace IntroducaoDelegate
{
    // Exemplo01
    //delegate double BinaryNumericOperation (double n1, double n2);
    // Exemplo02
    delegate void BinaryNumericOperation(double n1, double n2);

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo01
            //double a = 10;
            //double b = 12;

            ////double result = CalculationService.Square(a);

            //BinaryNumericOperation op = CalculationService.Sum;
            //// BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
            //double result = op(a, b);
            //// double result = op.Invoke(a, b);
            //Console.WriteLine(result);
            #endregion

            #region Exemplo02
            //double a = 10;
            //double b = 12;

            //BinaryNumericOperation op = CalculationService.ShowSum;

            //op += CalculationService.ShowMax;

            //op(a, b);
            #endregion
        }
    }
}
