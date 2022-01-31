using Herdar_CumprirContrato.Model.Entities;
using Herdar_CumprirContrato.Model.Enums;

namespace Herdar_CumprirContrato;
internal class Program
{
    static void Main(string[] args)
    {
        IShape s1 = new Circle()
        {
            Radius = 2.0,
            Color = Color.White
        };
        IShape s2 = new Rectangle()
        {
            Width = 3.5,
            Height = 4.2,
            Color = Color.Black
        };

        Console.WriteLine(s1 + "\n\n" + s2);

    }
}
