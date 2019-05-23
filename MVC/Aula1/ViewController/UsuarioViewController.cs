using System;
using System.Collections.Generic;
using Aula1.Repositorio;
using Aula1.Utils;
using Aula1.ViewModel;

namespace Aula1.ViewController
{
    public class UsuarioViewController
    {
        //Instanciar o repositorio

            static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        public static void CadastrarUsuario(){
            string nome, email, senha, confirmaSenha;
            do
            {
                System.Console.WriteLine("Digite o nome do mano:");
                nome = Console.ReadLine();
                if (string.IsNullOrEmpty(nome))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Nome não certo");
                    Console.ResetColor();
                }//fim if
            } while (string.IsNullOrEmpty(nome));

            do
            {
                System.Console.WriteLine("Coloca o e-mail ai:");
                email = Console.ReadLine();

                if (!ValidacaoUtil.ValidarEmail(email)){
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Email errado, o email tem que ter @ e .");
                Console.ResetColor();
                }
                
            } while (!ValidacaoUtil.ValidarEmail(email));

            do
            {
                System.Console.WriteLine("Coloca ai sua senha:");
                senha = Console.ReadLine();

                System.Console.WriteLine("Senha de novo:");
                confirmaSenha = Console.ReadLine();

                if (!ValidacaoUtil.ConfirmacaoSenha(senha, confirmaSenha))
                {
                    System.Console.WriteLine("Senha nao igual");
                }
                
            } while (!ValidacaoUtil.ConfirmacaoSenha(senha, confirmaSenha));

            //Cria um objeto do tipo usuario
            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;

            
            // metodo para inderir um banco de dados

            usuarioRepositorio.Inserir(usuarioViewModel);
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("Cadastro foi efetuado!");
            Console.ResetColor();

        }//fim cadastrar usuario

        public static void ListarUsuario()
        {
            List<UsuarioViewModel> listaDeUsuarios = usuarioRepositorio.Listar(); 

            foreach (var item in listaDeUsuarios)
            {
            System.Console.WriteLine($"Id: {item.Id}\nNome: {item.Nome}\nEmail: {item.Email}\nSenha: {item.Senha}\nData de criação: {item.DataCriacao}");
            }

        }

        public static UsuarioViewModel EfetuarLogin(){
            string email, senha;
            do
            {
                System.Console.WriteLine("Coloca o email:");
                email = Console.ReadLine();
                if (!ValidacaoUtil.ValidarEmail(email)){
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Email errado!");
                    Console.ResetColor();
                }
            } while (!ValidacaoUtil.ValidarEmail(email));

            System.Console.WriteLine("A senha mano:");
            senha = Console.ReadLine();
            
            UsuarioViewModel usuarioRecuperado = usuarioRepositorio.BuscarUsuario(email, senha);
            if (usuarioRecuperado != null)
            {
                return usuarioRecuperado;
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Email ou senha errados!");
                Console.ResetColor();
                return null;
            }
        }
    }
}