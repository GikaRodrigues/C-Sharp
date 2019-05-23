using System;
using System.Collections.Generic;
using AplicativoFInanceiro.Repositorio;
using AplicativoFInanceiro.Utils;
using AplicativoFInanceiro.ViewController;
using AplicativoFInanceiro.ViewModel;
using Spire.Doc;
using Spire.Doc.Documents;

namespace AplicativoFInanceiro {
    class Program {

        static void Main (string[] args) {

            int opcaoDeslogado = 0;
            int opcaoLogado = 0;
            int opcaoTransacao = 0;
            int opcaoExtrato = 0;
            TransacaoRepositorio transacaoRepositorio = new TransacaoRepositorio ();
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();

            do {
                MenuUtils.MenuDeslogado ();
                opcaoDeslogado = int.Parse (Console.ReadLine ());
                switch (opcaoDeslogado) {
                    case 1:
                        UsuarioViewController.CadastrarUsuario ();
                        break;
                    case 2:
                        UsuarioViewModel usuarioRecuperado = UsuarioViewController.EfetuarLogin ();
                        if (usuarioRecuperado != null) {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine ($"Seja bem vindo - {usuarioRecuperado.Nome}");
                            Console.ResetColor ();
                            do {
                                MenuUtils.MenuLogado ();
                                opcaoLogado = int.Parse (Console.ReadLine ());
                                switch (opcaoLogado) {
                                    case 1:
                                        do {
                                            MenuUtils.MenuTransacao ();
                                            opcaoTransacao = int.Parse (Console.ReadLine ());
                                            switch (opcaoTransacao) {
                                                case 1:
                                                    TransacaoViewController.CadastrarDespesa ();
                                                    break;
                                                case 2:
                                                    TransacaoViewController.DepositarNaConta ();
                                                    break;
                                            }

                                        } while (opcaoTransacao != 0);
                                        break;

                                    case 2:
                                        do {
                                            MenuUtils.MenuExtrato ();
                                            opcaoExtrato = int.Parse (Console.ReadLine ());
                                            switch (opcaoExtrato) {
                                                case 1:
                                                    TransacaoViewController.ListarCredito ();
                                                    break;
                                                case 2:
                                                    TransacaoViewController.ListarDeposito ();
                                                    break;
                                                case 3:
                                                    TransacaoViewController.SaldoAtual ();
                                                    break;
                                                case 4:
                                                    TransacaoViewController.Zipar ();
                                                    break;
                                                case 5:
                                                    List<TransacaoViewModel> extratoDeTransacoes = transacaoRepositorio.Listar ();
                                                    List<TransacaoViewModel> extratoDeDepositos = transacaoRepositorio.ListarDeposito ();

                                                    Spire.Doc.Document document = new Spire.Doc.Document ();
                                                    Paragraph paragraph = document.AddSection ().AddParagraph ();
                                                    foreach (var item in extratoDeTransacoes) {
                                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                        paragraph.AppendText ($"Descrição: {item.Descricao} \n Valor do Crédito: {item.ValorCredito} \n Data da Transação: {item.DataDaTransacao}\n");
                                                        Console.ResetColor ();
                                                    }
                                                    foreach (var item in extratoDeDepositos) {
                                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                        paragraph.AppendText ($"Descrição: {item.Descricao} \n Valor do Deposito: {item.ValorDeposito} \n Data da Transação: {item.DataDaTransacao}\n");
                                                        Console.ResetColor ();
                                                    }
                                                    document.SaveToFile ("Sample.doc", FileFormat.Doc);
                                                    try {
                                                        System.Diagnostics.Process.Start ("Sample.doc");
                                                    } catch {

                                                    }
                                                    break;
                                            }
                                        } while (opcaoExtrato != 0);
                                        break;
                                }
                            } while (opcaoLogado != 0);

                        }
                        break;
                    case 3:
                        UsuarioViewController.ListarUsuario ();
                        List<UsuarioViewModel> listaDeUsuarios = usuarioRepositorio.Listar ();
                        Spire.Doc.Document documento = new Spire.Doc.Document ();
                        Paragraph paragrafo = documento.AddSection ().AddParagraph ();
                        foreach (var item in listaDeUsuarios) {
                            paragrafo.AppendText ($"Nome: {item.Nome}\nData de Nascimento: {item.DataNascimento}\nEmail: {item.Email}\nSenha: {item.Senha}\n\n");
                            documento.SaveToFile ("Sample.doc", FileFormat.Doc);
                            try {
                                System.Diagnostics.Process.Start ("Sample.doc");
                            } catch {

                            }
                        }
                        break;

                    default:
                        break;
                }
            } while (opcaoDeslogado != 0);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine ("Obrigado pela atenção!");
            Console.ResetColor ();
        }
    }
}