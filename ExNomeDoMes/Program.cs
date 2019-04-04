using System;

namespace ExNomeDoMes
{
    class Program
    {
        static void Main(string[] args)
        {

            // int num = 1;

            // while(num != 0){
            // Console.WriteLine("Entre com o numero do mês ou 0 para sair:");
            // num = int.Parse(Console.ReadLine());

            // switch (num)
            // {
            //     case 1:
            //         Console.WriteLine("Janeiro");
            //         break;
            //     case 2:
            //         Console.WriteLine("Fevereiro");
            //         break;
            //     case 3:
            //         Console.WriteLine("Março");
            //         break;
            //     default:
            //     Console.WriteLine("Escolha um numero de 1 a 3");
            //     break;
            //     }//fim switch
            // }//fim while

            bool usuarioAindaQuerJogar = true;
            int cont = 3;

            while(cont >= 1 && usuarioAindaQuerJogar ) {
                System.Console.WriteLine("Vc tem mais {0} chances!", cont);
                string resposta = Console.ReadLine();
                usuarioAindaQuerJogar = resposta.Equals("sim") ? true : false;
                cont++;
            }
        }
    }
}
