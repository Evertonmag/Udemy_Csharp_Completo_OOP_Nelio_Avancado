namespace Extensions_Methods;
internal class Program
{
    static void Main(string[] args)
    {
        // Testando dia
        DateTime dt = DateTime.Now.AddDays(-5);

        Console.WriteLine(dt.ElapsedTime());

        // Testando dia
        DateTime dt1 = DateTime.Now.AddHours(-5);

        Console.WriteLine(dt1.ElapsedTime());

        Console.WriteLine("\n-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-\n");

        string s1 = "Good Morning dear students!";

        Console.WriteLine("Sem cortar: " + s1);
        Console.WriteLine("Cortando até o 10 caracter: " + s1.Cut(10));
    }
}
