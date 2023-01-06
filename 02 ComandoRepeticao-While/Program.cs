using System.Security.Cryptography.X509Certificates;

namespace _02_ComandoRepeticao_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;  
            while (i<=10)
            {
                int x = i * 5;
                Console.WriteLine($"5 * {i} = {x}");
                i++;
            }
            Console.WriteLine("------------------------------");


            for (int j = 1; j <= 10; j++)
            {
                int x = j * 7;
                Console.WriteLine($"7 * {j} = {x}");
            }
            Console.WriteLine("------------------------------");

        }
    }
}