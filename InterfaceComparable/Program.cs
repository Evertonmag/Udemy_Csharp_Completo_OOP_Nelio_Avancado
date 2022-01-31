using InterfaceComparable.Entities;
using System;

namespace InterfaceComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema01();
            Problema02();
        }

        static void Problema01()
        {
            string path = @"C:\Udemy\Csharp_ProgramacaoOrientadaObjeto\Udemy_Csharp_Completo_OOP_Nelio_Avancado\InterfaceComparable\Aula202\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }
                    list.Sort();
                    foreach (string str in list)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An errpr occurred");
                Console.WriteLine(ex.Message);
            }
        }

        static void Problema02()
        {
            string path = @"C:\Udemy\Csharp_ProgramacaoOrientadaObjeto\Udemy_Csharp_Completo_OOP_Nelio_Avancado\InterfaceComparable\Aula202\in2.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An errpr occurred");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
