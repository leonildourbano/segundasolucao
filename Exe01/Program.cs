namespace Exe01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aluno1 = "José"; 
            string aluno2 = "Pedro";

            double a1n1 = 8;
            double a1n2 = 5.2;
            double a2n1 = 6;
            double a2n2 = 5.7;

            double ma1 = 0;
            double ma2 = 0;

            Console.WriteLine($"{aluno1}: Nota 1: {a1n1} / Nota 2: {a1n2}");
            ma1 = (a1n1 + a1n2) / 2;
            Console.WriteLine($"Média: {ma1}");
            if (ma1 > 6)
            {
                Console.WriteLine("José aprovado");
            }
            else
            {
                Console.WriteLine("José reprovado");
            }

            Console.WriteLine("--------------------");

            Console.WriteLine($"{aluno2}: Nota 1: {a2n1} / Nota 2: {a2n2}");
            ma2 = (a2n1 + a2n2) / 2;
            Console.WriteLine($"Média: {ma2}");
            if (ma2 > 6)
            {
                Console.WriteLine("Pedro aprovado");
            }
            else
            {
                Console.WriteLine("Pedro reprovado");
            }
            Console.WriteLine("--------------------");
        }
    }
}