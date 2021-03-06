using LinqLambda.Entities;
using System.Linq;

namespace LinqLambda;
internal class Program
{
    static void Print<T>(string message, IEnumerable<T> collection)
    {
        Console.WriteLine(message);
        foreach (T obj in collection)
        {
            Console.WriteLine(obj);
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
        Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
        Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

        List<Product> products = new List<Product>()
        {
            new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
            new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
            new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
            new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
            new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
            new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
            new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
            new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
            new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
            new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
            new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
        };

        /*
         primeiro var é o codigo c#
         segundo var é o codigo similar ao SQL
         */

        //var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
        var r1 =
            from p in products
            where p.Category.Tier == 1 && p.Price < 900.0
            select p;
        Print("Tier 1 and price < 900: ", r1);

        //var r2 = products
        //    .Where(p => p.Category.Name == "Tools")
        //    .Select(p => p.Name);
        var r2 =
            from p in products
            where p.Category.Name == "Tools"
            select p.Name;
        Print("Names of product from tools: ", r2);

        //var r3 = products
        //    .Where(p => p.Name[0] == 'C')
        //    .Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
        var r3 =
            from p in products
            where p.Name[0] == 'C'
            select new { p.Name, p.Price, CategoryName = p.Category.Name };
        Print("Names started with 'C' and anonymous object", r3);

        //var r4 = products
        //    .Where(p => p.Category.Tier == 1)
        //    .OrderBy(p => p.Price)
        //    .ThenBy(p => p.Name);
        var r4 =
            from p in products
            where p.Category.Tier == 1
            orderby p.Name
            orderby p.Price
            select p;
        Print("Tier 1 Order by Price then by Name", r4);

        var r5 =
            (from p in products
             select p)
             .Skip(2)
             .Take(4);
        Print("Tier 1 Order by price then by name skip 2 take 4", r5);

        //var r6 = products.First();
        var r6 =
            (from p in products
             select p)
            .First();
        Console.WriteLine("First or default test 1: " + r6);

        //var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
        var r7 =
            (from p in products
             where p.Price > 3000.0
             select p)
             .FirstOrDefault();
        Console.WriteLine("First or deafult 2: " + r7);

        //var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
        var r8 =
            (from p in products
             where p.Id == 3
             select p)
             .SingleOrDefault();
        Console.WriteLine("Single or default test1: " + r8);

        //var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
        var r9 =
            (from p in products
             where p.Id == 30
             select p)
             .SingleOrDefault();
        Console.WriteLine("Single or default test2: " + r9);
        Console.WriteLine();

        //var r10 = products.Max(p => p.Price);
        var r10 =
            (from p in products
             select p)
             .Max(x => x.Price);
        Console.WriteLine("Max price: " + r10);

        //var r11 = products.Min(p => p.Price);
        var r11 =
            (from p in products
             select p)
             .Min(x => x.Price);
        Console.WriteLine("Min price: " + r11);

        //var r12 = products
        //    .Where(p => p.Category.Id == 1)
        //    .Sum(p => p.Price);
        var r12 =
            (from p in products
             where p.Category.Id == 1
             select p)
             .Sum(x => x.Price);
        Console.WriteLine("Category 1 sum prices: " + r12);

        //var r13 = products
        //    .Where(p => p.Category.Id == 1)
        //    .Average(p => p.Price);
        var r13 =
            (from p in products
             where p.Category.Id == 1
             select p)
             .Average(x => x.Price);
        Console.WriteLine("Category 1 Avarege prices: " + r13);

        //var r14 = products
        //    .Where(p => p.Category.Id == 5)
        //    .Select(p => p.Price)
        //    .DefaultIfEmpty(0.0)
        //    .Average();
        var r14 =
            (from p in products
             where p.Category.Id == 5
             select p.Price)
             .DefaultIfEmpty(0.0)
             .Average();
        Console.WriteLine("Category 5 Avarege prices: " + r14);

        //var r15 = products
        //    .Where(p => p.Category.Id == 1)
        //    .Select(p => p.Price)
        //    .Aggregate(0.0, (x, y) => x + y);
        var r15 =
            (from p in products
             where p.Category.Id == 1
             select p.Price)
             .Aggregate(0.0, (x, y) => x + y);
        Console.WriteLine("CAtegory 1 aggregate sum: " + r15);
        Console.WriteLine();

        //var r16 = products.GroupBy(p => p.Category);
        var r16 =
            from p in products
            group p by p.Category;
        foreach (IGrouping<Category, Product> group in r16)
        {
            Console.WriteLine("Category: " + group.Key.Name + ":");
            foreach (Product p in group)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
        }

    }
}