using ExercicioPropostoSecao17.Entities;
using System.Globalization;

namespace ExercicioPropostoSecao17;
internal class Program
{
    static void Main(string[] args)
    {
        // Fazer um programa para ler os dados  (nome,  email,  salario)  de
        // funcionarios a partir de um arquivo em formato .CSV.
        // Em seguida mostrar, em ordem alfabética, o email dos funcionarios
        // cujo salario seja superior a um dado valor fornecido pelo usuario.
        // Mostrar também a soma dos  salários  dos  funcionarios  cujo  nome
        // começa com a letra 'M'.

        // Path:
        // C:\Udemy\Csharp_ProgramacaoOrientadaObjeto\Udemy_Csharp_Completo_OOP_Nelio_Avancado\ExercicioPropostoSecao17\Aula233\in.txt

        Console.Write("Enter full file Path: ");
        string path = Console.ReadLine();
        Console.Write("Enter Salary: ");
        double salaryBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        List<Employee> employees = new List<Employee>();

        using(StreamReader sr = File.OpenText(path))
        {
            while (!sr.EndOfStream)
            {
                string[] fields = sr.ReadLine().Split(',');
                string name = fields[0];
                string email = fields[1];
                double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                employees.Add(new Employee(name, email, salary));
            }
        }

        Console.WriteLine($"Email of people whose salary is more than {salaryBase.ToString("F2", CultureInfo.InvariantCulture)}");
        var emails = employees
            .Where(e => e.Salary > salaryBase)
            .OrderBy(e => e.Email)
            .Select(e => e.Email);
        foreach(var email in emails)
        {
            Console.WriteLine(email);
        }

        var sumM = employees
            .Where(e => e.Name[0] == 'M')
            .Sum(e => e.Salary);

        Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sumM.ToString("F2", CultureInfo.InvariantCulture)}");

    }
}
