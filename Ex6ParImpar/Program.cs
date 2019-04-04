using System;

namespace Ex6ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string resposta;
            int numero;
            Random r = new Random();
            int numeroPC = r.Next(0,10);
            int soma = 0; 

            Console.WriteLine("Voçê quer jogar Par ou ímpar?");
            resposta = Console.ReadLine().ToLower();
            if (resposta.Equals("sim"))
            {
                 Console.WriteLine("Você escolhe ser par ou ímpar?");
            resposta = Console.ReadLine().ToLower();
            }else if (resposta.Equals("não"))
            {
               Console.WriteLine("Que pena, não queria mesmo!");
            }

            if (resposta.Equals("par"))
            {
                Console.WriteLine("Então eu sou ímpar");
            }else if (resposta.Equals("ímpar"))
            {
                Console.WriteLine("Então eu sou par");
            }

            Console.WriteLine("Escolha um numero de 0 a 10");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Eu escolho:");
            Console.WriteLine(numeroPC);
            soma = numero + numeroPC;

            Console.WriteLine("O número final foi: "+soma);

            if (+soma % 2 == 0)
            {
                Console.WriteLine("YOU WIN!");
            }else if (+soma % 2 == 1)
            {
                Console.WriteLine("YOU LOSE!");
            }
           
        }
    }
}
