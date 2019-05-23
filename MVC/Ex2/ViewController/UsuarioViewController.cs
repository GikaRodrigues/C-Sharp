using System;
using System.Collections.Generic;
using Ex2.Repositorio;
using Ex2.Utils;
using Ex2.ViewModel;

namespace Ex2.ViewController
{
    public class UsuarioViewController
    {
        
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

        public static void CadastrarUsuario(){
            string nome, email, senha;

            

            do
            {
                System.Console.WriteLine("Qual seu nome lek?");
                nome = Console.ReadLine();
                if (string.IsNullOrEmpty(nome))
                {
                    System.Console.WriteLine("Ae malandro n vo pergunta de novo!");
                }
            } while (string.IsNullOrEmpty(nome));

            do
            {
                System.Console.WriteLine("Seu E-mail jowl:");
                email = Console.ReadLine();

                if (!ValidacaoUtil.ValidarEmail(email)){
                     Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("E-mail está errado, seu e-mail tem q ter @ e .");
                    Console.ResetColor();
                }
            } while (!ValidacaoUtil.ValidarEmail(email));


                MenuUtil.StatusDoUsuario();
                int tipo = int.Parse(Console.ReadLine());
                

            do
            {
                System.Console.WriteLine("Agora bota uma senha ai:");
                senha = Console.ReadLine();
                if (!ValidacaoUtil.ValidarSenha(senha))
                {
                    System.Console.WriteLine("coloca uma senha maió q 5!");
                }
            } while (!ValidacaoUtil.ValidarSenha(senha));


            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Tipo = tipo;
            usuarioViewModel.Senha = senha;


            usuarioRepositorio.Inserir(usuarioViewModel);
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Cadastro concluido!");
            Console.ResetColor();
        }


            public static void ListarUsuario(){

                List<UsuarioViewModel> listaDeUsuarios = usuarioRepositorio.Listar();

                foreach (var item in listaDeUsuarios)
                {
                    System.Console.WriteLine($"Id: {item.Id}\nNome: {item.Nome}\nE-mail: {item.Email}\nSenha: {item.Senha}\nStatus usuario: {item.Tipo}\nData criação: {item.DataCriacao}");
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
                    System.Console.WriteLine("Email incorreto!");
                    Console.ResetColor();
                }
                } while (!ValidacaoUtil.ValidarEmail(email));

                System.Console.WriteLine("Agora a senha campeão:");
                senha = Console.ReadLine();
                
                UsuarioViewModel usuarioRecuperado = usuarioRepositorio.BuscarUsuario(email, senha);
            if (usuarioRecuperado != null)
            {
                return usuarioRecuperado;
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Email ou senha incoreto!");
                Console.ResetColor();
                return null;
            }
        }
    }
}