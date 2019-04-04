using System;

namespace Previsão
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diga-me a previsao do tempo e lhe direi o que fazer");
            string clima = Console.ReadLine().ToLower();

            if (clima.Equals("Frio")) 
            {
                Console.WriteLine("Vamos à Montanha!");
            }
            else if (clima.Equals("Quente")) 
            {
                Console.WriteLine("Vamos à Praia!");
            }
            else if (clima.Equals("chuva"))
            {
                Console.WriteLine("Vamos para Steam?");
                string resposta = Console.ReadLine();
                if (resposta.Equals("Não"))
                {
                    Console.WriteLine("Vamos à Netflix!");
                }
            }else{
                Console.WriteLine("Valor inválido \n Digite: frio, calor ou chuva seu burro!?");
            }

        }
    }
}
