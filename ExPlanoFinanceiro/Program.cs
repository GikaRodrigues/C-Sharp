using System;
using Ex2.Utils;
using Ex2.ViewController;
using Ex2.ViewModel;

namespace Ex2_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslogado = 0;
            int opcaoLogado = 0;

            do
            {
                MenuUtil.MenuDeslogado();
                opcaoDeslogado = int.Parse(Console.ReadLine());
                switch (opcaoDeslogado)
                {
                    case 1:
                    UsuarioViewController.CadastrarUsuario();
                    break;
                    case 2:
                    UsuarioViewModel usuarioRecuperado = UsuarioViewController.EfetuarLogin();
                    if (usuarioRecuperado != null){
                    System.Console.WriteLine($"Seja Bem Vindo - {usuarioRecuperado.Nome}");
                    MenuUtil.MenuLogado();
                    opcaoLogado = int.Parse(Console.ReadLine());
                    do
                    {
                        switch (opcaoLogado)
                        {
                            case 1:
                            break;
                            case 2:
                            break;
                        }
                    } while (opcaoLogado != 0);
                    System.Console.WriteLine("Obrigado pela atenção!");
                    }
                    break;
                    case 3:
                    UsuarioViewController.ListarUsuario();
                    break;
                }
            } while (opcaoDeslogado != 0);
            System.Console.WriteLine("Obrigado pela atenção!");
        }
    }
}
