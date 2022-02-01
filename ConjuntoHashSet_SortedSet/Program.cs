using ConjuntoHashSet_SortedSet.Entities;

namespace ConjuntoHashSet_SortedSet;
internal class Program
{
    static void Main(string[] args)
    {
        //ExemploBasicoConjuntoHashSet();
        //ExemploBasicoConjuntoSortedSet();
        ComparandoIgualdadeComColecaoHash();
    }

    static void ExemploBasicoConjuntoHashSet()
    {
        HashSet<string> set = new HashSet<string>();

        set.Add("TV");
        set.Add("Notebook");
        set.Add("Tablet");

        Console.WriteLine(set.Contains("Computer"));

        foreach (string p in set)
        {
            Console.WriteLine(p);
        }
    }

    static void ExemploBasicoConjuntoSortedSet()
    {
        SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
        SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

        // Union
        SortedSet<int> c = new SortedSet<int>(a);
        c.UnionWith(b);

        PrintCollection(c);

        //Intersection
        SortedSet<int> d = new SortedSet<int>(a);
        d.IntersectWith(b);

        PrintCollection(d);

        // Difference
        SortedSet<int> e = new SortedSet<int>(a);
        e.ExceptWith(b);

        PrintCollection(e);

    }
    static void PrintCollection <T>(IEnumerable<T> collection)
    {
        foreach (T obj in collection)
        {
            Console.Write(obj + " ");

        }
        Console.WriteLine();

    }

    static void ComparandoIgualdadeComColecaoHash()
    {
        HashSet<Product> a = new HashSet<Product>();

        a.Add(new Product("TV", 900.00));
        a.Add(new Product("Notebook", 1200.00));

        HashSet<Point> b = new HashSet<Point>();
        b.Add(new Point(3, 4));
        b.Add(new Point(5, 10));


        Product prod = new Product("Notebook", 1200.00);

        Console.WriteLine(a.Contains(prod));

        Point p = new Point(5, 10);
        Console.WriteLine(b.Contains(p));

    }
}

