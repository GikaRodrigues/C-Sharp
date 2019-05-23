using System;

namespace Aula1.Utils
{
    public class MenuUtil
    {
        /// <sumary>Exibe as opções do usuário Deslogado</sumary>
        public static void MenuDeslogado(){
            Console.WriteLine("7777777777777777777777777777777777777");
            Console.WriteLine("*---------------TSUSHI--------------*");
            Console.WriteLine("*------ (1) Cadastrar Usuário ------*");
            Console.WriteLine("*------ (2) Efetuar Login ----------*");
            Console.WriteLine("*------ (3) Listar -----------------*");
            Console.WriteLine("*-----------------------------------*");
            Console.WriteLine("*---------Escolha uma opção---------*");
            Console.WriteLine("7777777777777777777777777777777777777");
        }//fim menu deslogado

        public static void MenuLogado(){
            Console.WriteLine("7777777777777777777777777777777777777");
            Console.WriteLine("*---------Restaurante TsuShi--------*");
            Console.WriteLine("*-----------   Cardápio   ----------*");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("*    (1) Cadastrar Produto          *");
            Console.WriteLine("*    (2) Listar todos os produtos   *");
            Console.WriteLine("*    (3) Buscar produto por Id      *");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("*             (0) Sair              *");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("*---------Escolha uma opção---------*");
            Console.WriteLine("7777777777777777777777777777777777777");

        }
    }
}