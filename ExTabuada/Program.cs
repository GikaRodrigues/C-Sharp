using System;

namespace ExTabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repetir = true;
            int cont = 0;

            Console.WriteLine("Qual a tabuada vc quer mano?");
            int num = int.Parse(Console.ReadLine());

            while (repetir)
            {
                Console.WriteLine(num + "x" + cont + "=" +num * cont);
            cont++;
                

            while(cont <= 10){
            Console.WriteLine(num + "x" + cont + "=" +num * cont);
            cont++;

            }
            Console.WriteLine("Repetir?");
            string resposta = Console.ReadLine();
            repetir = resposta.Equals("não") ? false : true;
            repetir = resposta.Equals("sim") ? true : false;
            Console.WriteLine("Qual é a outra que vc quer?");
            cont--;
            }

        }
    }
}
