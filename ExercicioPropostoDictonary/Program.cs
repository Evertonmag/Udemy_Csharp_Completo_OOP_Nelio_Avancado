namespace ExercicioPropostoDictonary;
internal class Program
{
    static void Main(string[] args)
    {
        // Input file:
        // C:\Udemy\Csharp_ProgramacaoOrientadaObjeto\Udemy_Csharp_Completo_OOP_Nelio_Avancado\ExercicioPropostoDictonary\aula214\in.txt

        Console.Write("Enter file full path: ");
        string path = Console.ReadLine();

        try
        {
            string Candidato = null;
            int voto = 0;

            Dictionary<string, int> votacao = new Dictionary<string, int>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] vect = sr.ReadLine().Split(",");
                    Candidato = vect[0];
                    voto = int.Parse(vect[1]);

                    if (votacao.ContainsKey(Candidato))
                        votacao[Candidato] += voto;
                    else
                        votacao[Candidato] = voto;
                }
                foreach(KeyValuePair<string, int> item in votacao)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }

            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An Error ocurred: {ex.Message}");
        }

    }
}
