using System;

namespace ExArreyImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descobrindo numeros Impares:");

            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            for (int i = 0; i < 16; i++){
                Console.WriteLine(numeros[i]);

                if (numeros [i] %2!= 0)
                {
                    System.Console.WriteLine("Impar");
                }else
                {
                    System.Console.WriteLine("Par");
                }
            }

            //---------------------------------------------------------

            int[] nCasa = new int[3];

            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine("Digite o Nº da casa:");
                Console.ReadLine();
            }

            foreach (var nCasas in nCasa)
            {
                System.Console.Write($"{nCasa},");
            }

            //----------------------------------------------------------
        }
    }
}
