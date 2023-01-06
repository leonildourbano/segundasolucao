namespace _01_Comandos_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //comando if - Se (teste verdadeiro)
            int idade = 18;
            double altura = 1.60;

            //comando if  -  Se (teste Verdadeiro) 
            if (idade >= 18)
            {
                if (altura > 1.50)
                {
                    Console.WriteLine("Pode entrar");
                }
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }


        }
    }
}