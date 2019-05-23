using System;

namespace ExAirLines
{
    class Program
    {
        // static void Main(string[] args)
        // {

        //     Console.WriteLine("Bem Vindos ao Vôe Tranquilo Airlines");

        //     string[] nomes = new string[3];
        //     int[] nPassagem = new int[3];
        //     DateTime[] data = new DateTime[3];

        //     for (int i = 1; i <= 3; i++)
        //     {
        //         Console.WriteLine("-----Escolha uma opção abaixo:-----");
        //         Console.WriteLine("1 - Registrar Passagem");
        //         Console.WriteLine("2 - Visualizar Passagem");
        //         Console.WriteLine("0 - Sair");
        //         int resposta = int.Parse(Console.ReadLine());

        //         if (resposta.Equals(1))
        //         {
        //             Console.WriteLine($"Digite o nome {i}º passageiro:");
        //             nomes[i] = Console.ReadLine();

        //             Console.WriteLine("Digite o numero da passagem:");
        //             nPassagem[i] = int.Parse(Console.ReadLine());

        //             Console.WriteLine("Digite a data do voo dd/mm/aaaa:");
        //             data[i] = DateTime.Parse(Console.ReadLine());


        //         }
        //         if (resposta.Equals(2))
        //         {
        //             for (int j = 0; j < 3; j++)
        //             {
        //                 Console.WriteLine($"O comprador {nomes[j]} agendou a passagem {nPassagem[j]} para o dia {data[j]:dd/MMM/yyyy}.");
        //             }
        //         }
        //         if (resposta.Equals(0))
        //         {
        //             Console.WriteLine("A Vôe Tranquilo agradece!");
        //             Console.WriteLine("-----Volte sempre------");
        //             i = 7;
        //         }

        //     }

        // }

        static void Main (string[] args) {
            System.Console.WriteLine ("Bem-vindo à Tsukamoto Airlines");
            bool sair = false;
            Passageiro[] passageiros = new Passageiro[2];
            int passageirosCadastrados = 0;
            do {
                System.Console.WriteLine ("Escolha uma opção:");
                System.Console.WriteLine ("1 - Registrar Passageiro");
                System.Console.WriteLine ("2 - Exibir Passagens");
                System.Console.WriteLine ("0 - Sair");

                int codigo = int.Parse (Console.ReadLine ());

                switch (codigo) {
                    case 1:
                        Console.WriteLine ("Digite o nome do passageiro");
                        Passageiro p = new Passageiro ();
                        p.setNome (Console.ReadLine ());
                        passageiros[passageirosCadastrados] = p;

                        passageirosCadastrados++;
                        Console.WriteLine ("Passageiro cadastrado com sucesso!");
                        break;
                    case 2:

                        Console.WriteLine ("Todos os passageiros cadastrados");
                        foreach (var passageiro in passageiros) {
                            if (passageiro != null) {
                                Console.WriteLine (passageiro.getNome ());
                            }
                        }

                        break;
                        
                    case 0:
                        sair = true;
                        break;

                }

            } while (!sair);
        }
    }
}
