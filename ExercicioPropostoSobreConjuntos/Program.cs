namespace ExercicioPropostoSobreConjuntos;
internal class Program
{
    static void Main(string[] args)
    {
        // Em um portal de cursos online, cada usuário possui um código único, representado por
        // um número inteiro.
        // Cada instrutor do portal pode ter vários cursos, sendo que um mesmo aluno pode se
        // matricular em quantos cursos quiser.Assim, o número total de alunos de um instrutor não
        // é simplesmente a soma dos alunos de todos os cursos que ele possui, pois pode haver
        // alunos repetidos em mais de um curso.
        // O instrutor Alex possui três cursos A, B e C do Instrutor Alex, depois mostrar a quantidade
        // total e alunos dele, Conforme exemplo:
        // How many students for course A? 3
        // 21
        // 35
        // 22
        // How many students for course B? 2
        // 21
        // 50
        // How many students for course C? 3
        // 42
        // 35
        // 13
        // Total students: 6

        HashSet<int> CourseA = new HashSet<int>();
        HashSet<int> CourseB = new HashSet<int>();
        HashSet<int> CourseC = new HashSet<int>();

        Console.Write("How many students for course A? ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int cod = int.Parse(Console.ReadLine());
            CourseA.Add(cod);
        }
        Console.Write("How many students for course B? ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int cod = int.Parse(Console.ReadLine());
            CourseB.Add(cod);
        }
        Console.Write("How many students for course C? ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int cod = int.Parse(Console.ReadLine());
            CourseC.Add(cod);
        }

        HashSet<int> all = new HashSet<int>(CourseA);
        all.UnionWith(CourseB);
        all.UnionWith(CourseC);
        Console.WriteLine($"Total students: {all.Count}");
    }
}