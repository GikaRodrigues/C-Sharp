using System;
using AplicativoFInanceiro.Repositorio;
using System.Collections.Generic;
using AplicativoFInanceiro.Utils;
using AplicativoFInanceiro.ViewModel;

namespace AplicativoFInanceiro.ViewController {
    public class UsuarioViewController {

        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();

        public static void CadastrarUsuario () {
            string nome, email, senha, confirmaSenha;
            DateTime dataNascimento;

            do {

                System.Console.WriteLine ("Digite o Nome do Usuário");
                nome = Console.ReadLine ();
                if (string.IsNullOrEmpty (nome)) {
                    System.Console.WriteLine ("Nome inválido!");
                } //fim if

            } while (string.IsNullOrEmpty (nome));
            do {
                System.Console.WriteLine ("Digite sua data de nascimento");
                dataNascimento = DateTime.Parse(Console.ReadLine());

            } while (false);

            do {
                System.Console.WriteLine ("Digite o email do usuário");
                email = Console.ReadLine ();

                if (!ValidacaoUtil.ValidarEmail (email)) {
                    System.Console.WriteLine ("Email inválido!");

                }

            } while (!ValidacaoUtil.ValidarEmail (email));
            do {
                System.Console.WriteLine ("Digite a senha do usuário");
                senha = Console.ReadLine ();

                System.Console.WriteLine ("Confirme a senha");
                confirmaSenha = Console.ReadLine ();

                if (!ValidacaoUtil.ConfirmacaoSenha (senha, confirmaSenha)) {
                    System.Console.WriteLine ("AS senhas não são iguais");
                }
            } while (!ValidacaoUtil.ConfirmacaoSenha (senha, confirmaSenha));

            UsuarioViewModel usuarioViewModel = new UsuarioViewModel ();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;
            usuarioViewModel.DataNascimento = dataNascimento;

            usuarioRepositorio.Inserir (usuarioViewModel);
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine ("Cadastro efetuado com sucesso!");
            Console.ResetColor();

        }
        public static void ListarUsuario()
        {
            List<UsuarioViewModel> listaDeUsuarios = usuarioRepositorio.Listar();

            foreach (var item in listaDeUsuarios)
            {
                Console.WriteLine($"Nome: {item.Nome}\nData de Nascimento: {item.DataNascimento}\nEmail: {item.Email}\nSenha: {item.Senha}");

            }
        }
        public static UsuarioViewModel EfetuarLogin () {
            string email, senha;
            do {
                Console.WriteLine ("Insira o email:");
                email = Console.ReadLine ();
                if (!ValidacaoUtil.ValidarEmail (email)) {
                    Console.WriteLine ("Email Inválido");
                }
            } while (!ValidacaoUtil.ValidarEmail (email));

            Console.WriteLine ("Digite a senha");
            senha = Console.ReadLine ();

            UsuarioViewModel usuarioRecuperado = usuarioRepositorio.BuscarUsuario (email, senha);
            if (usuarioRecuperado != null) {
                return usuarioRecuperado;
            } else {
                Console.WriteLine ("E-mail ou senha inválida");
                return null;
            }


        }
    }

}