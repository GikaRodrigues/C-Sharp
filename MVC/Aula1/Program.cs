using System;
using Aula1.Utils;
using Aula1.ViewController;
using Aula1.ViewModel;

namespace Aula1
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
                  //Cadastra usuario
                  UsuarioViewController.CadastrarUsuario();
                  break;
                  case 2:
                  //Efetua Login
                  UsuarioViewModel usuarioRecuperado = UsuarioViewController.EfetuarLogin();
                  if (usuarioRecuperado != null)
                  {
                      System.Console.WriteLine($"Seja bien vindo - {usuarioRecuperado.Nome}");
                      MenuUtil.MenuLogado();
                      opcaoLogado = int.Parse(Console.ReadLine());
                      do
                      {
                        switch (opcaoLogado)
                        {
                            case 1:
                            ProdutoViewController.CadastrarProduto();
                            break;
                            case 2:
                            ProdutoViewController.ListarProduto();
                            break;
                            case 3:
                            ProdutoViewController.BuscarId();
                            break;
                        }
                      } while (opcaoLogado != 0);
                  }

                  break;
                  case 3:
                  //Listar
                  UsuarioViewController.ListarUsuario();
                  break;
                  case 0:
                  //Sair
                  break;
                  default:
                  System.Console.WriteLine("Opção Inválida");
                  break;


              }

           } while (opcaoDeslogado != 0); 
        }
    }
}
