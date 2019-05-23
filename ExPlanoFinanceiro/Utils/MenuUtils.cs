using System;

namespace Ex2.Utils
{
    public class MenuUtil
    {
        
        public static void MenuDeslogado () {
            string barraMenu = "================================";
            System.Console.WriteLine (barraMenu);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine ("      Aplicativo Financeiro     ");
            Console.ResetColor ();
            System.Console.WriteLine (barraMenu);
            System.Console.WriteLine ("||     (1)  Cadastrar Usuário  ||");
            System.Console.WriteLine ("||     (2)  Efetuar Login      ||");
            System.Console.WriteLine ("||     (3)  Listar Usuários    ||");
            System.Console.WriteLine ("||     (0)  Sair               ||");
        }

        public static void MenuLogado () {
            string barraMenu = "================================";
            System.Console.WriteLine (barraMenu);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine ("          Status da conta       ");
            Console.ResetColor ();
            System.Console.WriteLine (barraMenu);
            System.Console.WriteLine ("||     (1)  Fazer Transação    ||");
            System.Console.WriteLine ("||     (2)  Tirar extrato      ||");
            System.Console.WriteLine ("||     (0)  Sair               ||");
        }
        public static void MenuTransacao(){
            string barraMenu = "================================";
            System.Console.WriteLine (barraMenu);
            System.Console.WriteLine ("          Status da conta       ");
            System.Console.WriteLine (barraMenu);
            System.Console.WriteLine ("||     (1)  Fazer Transação    ||");
            System.Console.WriteLine ("||     (2)  Tirar extrato      ||");
            System.Console.WriteLine ("||     (0)  Sair               ||");
        }

        public static void StatusDoUsuario(){
            Console.WriteLine(" Status do Usuario ");
            Console.WriteLine("                   ");
            Console.WriteLine("  (1) ADM          ");
            Console.WriteLine("  (2) Usuario      ");
        }
    }
}