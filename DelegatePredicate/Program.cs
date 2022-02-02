using DelegatePredicate.Entities;

namespace DelegatePredicate;
internal class Program
{
    static void Main(string[] args)
    {
        List<Product> list = new List<Product>();

        list.Add(new Product("TV", 900.00));
        list.Add(new Product("Mouse", 50.00));
        list.Add(new Product("Tablet", 350.50));
        list.Add(new Product("HD Case", 80.90));

        #region Predicate

        //list.RemoveAll(ProductTest);

        #endregion

        #region Action

        //Action<Product> act = UpdatePrice;
        //Action<Product> act1 = p => { p.Price += p.Price * 0.1; };
        //list.ForEach(p => { p.Price += p.Price * 0.1; });
        //list.ForEach(act);
        //list.ForEach(act1);

        #endregion

        #region Func

        //List<string> result = list.Select(NameUpper).ToList();
        //List<string> result = list.Select(NameUpper).ToList();
        //Func<Product, string> func = NameUpper;
        //Func<Product, string> func = p => p.Name.ToUpper();
        //List<string> result = list.Select(func).ToList();
        List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

        #endregion

        //foreach (Product p in list)
        //{
        //    Console.WriteLine(p);
        //}
        //foreach (string p in result)
        //{
        //    Console.WriteLine(p);
        //}
    }

    public static bool ProductTest(Product p) => p.Price >= 100.0;

    static void UpdatePrice(Product p) => p.Price += p.Price * 0.1;

    static string NameUpper(Product p) => p.Name.ToUpper();

}
