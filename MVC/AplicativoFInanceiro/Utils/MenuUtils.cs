using System;
namespace AplicativoFInanceiro.Utils {
    public class MenuUtils {

        public static string barraMenu = "================================";
        public static void MenuDeslogado () {
            Console.Clear();
            System.Console.WriteLine (barraMenu);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine ("      APLICATIVO FINANCEIRO     ");
            Console.ResetColor ();
            System.Console.WriteLine (barraMenu);
            System.Console.WriteLine ("||     (1)  Cadastrar Usuário  ||");
            System.Console.WriteLine ("||     (2)  Efetuar Login      ||");
            System.Console.WriteLine ("||     (3)  Listar Usuários    ||");
            System.Console.WriteLine ("||     (0)  Sair               ||");
        }

        public static void MenuLogado () {
            System.Console.WriteLine (barraMenu);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine ("          STATUS DA CONTA       ");
            Console.ResetColor ();
            System.Console.WriteLine (barraMenu);
            System.Console.WriteLine ("||     (1)  Fazer Transação    ||");
            System.Console.WriteLine ("||     (2)  Tirar extrato      ||");
            System.Console.WriteLine ("||     (0)  Sair               ||");
        }
        public static void MenuTransacao () {

            System.Console.WriteLine (barraMenu);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine ("        TIPOS DE TRANSAÇÃO       ");
            Console.ResetColor ();
            System.Console.WriteLine ("||       (1)  Despesa         ||");
            System.Console.WriteLine ("||       (2)  Depositar       ||");
            System.Console.WriteLine ("||       (0)  Sair            ||");

        }
        public static void MenuExtrato () {
            System.Console.WriteLine (barraMenu);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine("             EXTRATO             ");
            Console.ResetColor();
            System.Console.WriteLine ("||    (1) Transferências       ||");
            System.Console.WriteLine ("||    (2) Depositos na conta   ||");
            System.Console.WriteLine ("||    (3) Saldo Atual          ||");
            System.Console.WriteLine ("||    (4) Zipar Extrato        ||");
            System.Console.WriteLine ("||    (5) Gerar Doc            ||");
            System.Console.WriteLine ("||    (0) Sair                 ||");


        }
    }
}