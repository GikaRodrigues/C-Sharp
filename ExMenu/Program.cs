using System;

namespace ExMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repetir = true;
            Console.WriteLine("Aplicação - Criando Menus");
            
            while (repetir)
            {
                Console.WriteLine("Selecione uma opção desejada");
                Console.WriteLine("1 - Efetuar Login");
                Console.WriteLine("2 - Listar Contatos");
                Console.WriteLine("3 - Listar Comentários");
                Console.WriteLine("9 - Sair");
                int resposta = int.Parse(Console.ReadLine());

                switch (resposta)
                {
                    case 1:
                        Console.WriteLine("Digite seu usuario:");
                        string usuario = Console.ReadLine();
                       
                        if (usuario == "Giovanni")
                        {
                             Console.WriteLine("Digite sua senha:");
                             string senha = Console.ReadLine();
                             if (senha == "123")
                             {
                                 Console.WriteLine("Bem Vindo -{0}" ,usuario);
                             }else{
                                 Console.WriteLine("Senha Errada");
                             }
                        }else{
                            Console.WriteLine("Usuário Inexistente");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Tsukamoto - 9828888");
                        Console.WriteLine("Cesar - 3000000");
                        break;
                    case 3:
                        Console.WriteLine("Parabéns aos desenvolvedores");
                        Console.WriteLine("Adorei o Programa");

                        break;
                    case 9:
                        repetir = false;
                        break;    
                    default:
                        Console.WriteLine("Valor Inválido");
                        break;
                }//fim switch

            }//fim while
        }//fim main
    }//fim class
}//fim