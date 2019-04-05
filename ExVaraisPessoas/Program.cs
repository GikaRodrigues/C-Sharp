using System;

namespace ExVaraisPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            int maiores = 0;
            int menores = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Qual a idade:");
                int idade = int.Parse(Console.ReadLine());

                if (idade >= 18)
                {
                    maiores++;
                }else
                {
                    menores++;
                }

                
            }//fimfor

                Console.WriteLine("{0}" ,maiores+ "é de maior, pode votar!");
                Console.WriteLine("{0}" ,menores+ "é de maior, pode votar!");
            

        }
    }
}
