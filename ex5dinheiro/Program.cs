using System;

namespace ex5dinheiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double valor1;
            double valor2;

            double resultado;

            Console.WriteLine("Digite o primeiro valor");
            valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            valor2 = double.Parse(Console.ReadLine());

            resultado = valor1 - valor2;

            if (resultado > 0)
            {
                Console.WriteLine("Primeiro numero é maior");
            }else if (resultado < 0)
            {
                Console.WriteLine("Segundo numero é maior");
            }

            Console.WriteLine("O maior valor é: ");
        }
    }
}
