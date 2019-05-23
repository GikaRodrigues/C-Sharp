using System;

namespace Ex2.Utils
{
    public class MenuUtil
    {
        
        public static void MenuDeslogado(){
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("^             Menu           V");
            Console.WriteLine("^                            V");
            Console.WriteLine("^      (1) Criar Conta       V");
            Console.WriteLine("^      (2) Fazer Login       V");
            Console.WriteLine("^      (3) Mostrar Dados     V");
            Console.WriteLine("^      (0) Sair              V");
            Console.WriteLine("^                            V");
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
        }

        public static void MenuLogado(){
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("^      Menu do Usuário       V");
            Console.WriteLine("^                            V");
            Console.WriteLine("^      (1) Criar Tarefas     V");
            Console.WriteLine("^      (2) Mostrar Tarefas   V");
            Console.WriteLine("^      (0) Sair              V");
            Console.WriteLine("^                            V");
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
        }

        public static void StatusDaTarefa(){
            Console.WriteLine("  Status da tarefa ");
            Console.WriteLine("                   ");
            Console.WriteLine("  (1) Para Fazer   ");
            Console.WriteLine("  (2) Fazendo      ");
            Console.WriteLine("  (3) Feito        ");
        }

        public static void StatusDoUsuario(){
            Console.WriteLine(" Status do Usuario ");
            Console.WriteLine("                   ");
            Console.WriteLine("  (1) ADM          ");
            Console.WriteLine("  (2) Usuario      ");
        }
    }
}