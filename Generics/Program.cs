namespace Generics;
internal class Program
{
    static void Main(string[] args)
    {
        PrintService<int> printService = new PrintService<int>();

        Console.Write("How namy values? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            printService.AddValue(x);
        }

        int a = printService.First();
        int b = a;
        Console.Write(b);

        printService.Print();

        Console.WriteLine("First: " + printService.First());

    }
}
