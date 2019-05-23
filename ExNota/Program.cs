using System;

namespace ExNota
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo ao Calculador de Tranquilidade:)");

            string[] nomes = new string[5];
            string[] sobrenome = new string[5];
            int[] notas = new int[5];
            int[] notas2 = new int[5];
            float[] medias = new float[5];

            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine("Cadastre o aluno e depois veja sua media:");
                Console.WriteLine("1 - cadastrar");
                Console.WriteLine("2 - olhar a média");
                Console.WriteLine("0 - sair");
                int resposta = int.Parse(Console.ReadLine());

                if (resposta.Equals(1))
                {
                Console.WriteLine($"Qual o nome do {i}º aluno");
                nomes[i] = Console.ReadLine();

                Console.WriteLine($"Qual o sobrenome do {i}º aluno");
                sobrenome[i] = Console.ReadLine();

                Console.WriteLine("Qual foi a nota 1:");
                notas[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual foi a nota 2:");
                notas2[i] = int.Parse(Console.ReadLine());

                medias[i] = (notas[i] + notas2[i])/2;
                
                }else if (resposta.Equals(0))
                {
                    System.Console.WriteLine("Obrigado pela atenção!");
                    i = 100;
                }else if (resposta.Equals(2))
                {
                    for (int j = 1; j < 3; j++)
                    {
                        Console.WriteLine($"O aluno {nomes[j]} {sobrenome[j]} ficou com uma media de: {medias[j]}");

                        if (medias[j] >= 50)
                        {
                            System.Console.WriteLine("Aluno Aprovado, Parabens!");
                        }else
                        {
                            System.Console.WriteLine("Aluno Reprovado, Tente outra vez!");
                        }
                    }
                }
                
            }
        }
    }
}
