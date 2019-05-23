using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Reflection.Metadata;
using AplicativoFInanceiro.Repositorio;
using AplicativoFInanceiro.ViewModel;
using Spire.Doc;
using Spire.Doc.Documents;

namespace AplicativoFInanceiro.ViewController {
    public class TransacaoViewController {
        public static double saldoIncial = 0;

        static TransacaoViewModel transacaoViewModel = new TransacaoViewModel ();
        static TransacaoRepositorio transacaoRepositorio = new TransacaoRepositorio ();

        public static void CadastrarDespesa () {
            string descricao;
            double valorCredito;

            do {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine ("Descreva a transação (ex: Conta para pagar)       ");
                Console.ResetColor ();
                descricao = Console.ReadLine ();
                if (string.IsNullOrWhiteSpace (descricao)) {
                    System.Console.WriteLine ("Descreva a transação (ex: Conta para pagar)       ");

                }

            } while (string.IsNullOrWhiteSpace (descricao));

            do {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine ("Digite o valor que deseja creditar da sua conta:   ");
                Console.ResetColor ();
                valorCredito = double.Parse (Console.ReadLine ());
                if (valorCredito <= 0) {
                    System.Console.WriteLine ("Valor inválido");
                } else {
                    continue;
                }

            } while (valorCredito <= 0);
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine ($"Você debitou: {valorCredito} reais da sua conta");
            Console.ResetColor ();

            TransacaoViewModel transacaoCreditoViewModel = new TransacaoViewModel ();
            transacaoCreditoViewModel.Descricao = descricao;
            transacaoCreditoViewModel.ValorCredito = valorCredito;
            transacaoCreditoViewModel.DataDaTransacao = DateTime.Now;
            

            transacaoRepositorio.InserirCredito (transacaoCreditoViewModel);
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine ("Transação efetuada com sucesso");
            Console.ResetColor ();

        }
        public static void ListarCredito () {
            List<TransacaoViewModel> extratoDeTransacoes = transacaoRepositorio.Listar ();
            foreach (var item in extratoDeTransacoes) {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                System.Console.WriteLine ($"Descrição: {item.Descricao} - Valor do Crédito: {item.ValorCredito} - Data da Transação: {item.DataDaTransacao}\n");
                Console.ResetColor ();
            }
        }
        public static void DepositarNaConta () {
            string descricao;
            double valorDeposito;
            do {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine ("Descreva a transação (ex: Salário do mês)       ");
                Console.ResetColor ();
                descricao = Console.ReadLine ();
                if (string.IsNullOrWhiteSpace (descricao)) {
                    System.Console.WriteLine ("Descreva a transação (ex: Conta para pagar)       ");

                }

            } while (string.IsNullOrWhiteSpace (descricao));
            do {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine ("Digite o valor que deseja depositar na sua conta:   ");
                Console.ResetColor ();
                valorDeposito = double.Parse (Console.ReadLine ());
                if (valorDeposito <= 0) {
                    System.Console.WriteLine ("Valor inválido");
                } else {
                    continue;
                }

            } while (valorDeposito <= 0);
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine ($"Você depositou: {valorDeposito} reais na sua conta");
            Console.ResetColor ();

            TransacaoViewModel transacaoCreditoViewModel = new TransacaoViewModel ();
            transacaoCreditoViewModel.Descricao = descricao;
            transacaoCreditoViewModel.ValorDeposito = valorDeposito;
            transacaoCreditoViewModel.DataDaTransacao = DateTime.Now;
            

            transacaoRepositorio.InserirDeposito (transacaoCreditoViewModel);
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine ("Transação efetuada com sucesso");
            Console.ResetColor ();

        }
        public static void ListarDeposito () {
            List<TransacaoViewModel> extratoDeTransacoes = transacaoRepositorio.ListarDeposito ();
            foreach (var item in extratoDeTransacoes) {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                System.Console.WriteLine ($"Descrição: {item.Descricao} - Valor do Deposito: {item.ValorDeposito} - Data da Transação: {item.DataDaTransacao}\n");
                Console.ResetColor ();
            }
        }
        public static void SaldoAtual () {
            List<TransacaoViewModel> extratoDeTransacoes = transacaoRepositorio.Listar ();
            List<TransacaoViewModel> extratoDeDepositos = transacaoRepositorio.ListarDeposito ();

            // foreach (var item in extratoDeTransacoes) {
            //     foreach (var i in extratoDeDepositos) {
            //         if (item.ValorCredito > saldoIncial) {
            //             Despesas = item.ValorCredito;

            //         }
            //         if (i.ValorDeposito > saldoIncial) {
            //             Depositos = i.ValorDeposito;

            //         }

            //         double SaldoAtual = Depositos- Despesas;
            //         System.Console.WriteLine ($"Seu saldo atual é {SaldoAtual}");
            //     }
            // }
            double totalCredito = 0;
            double totalDebito = 0;

            foreach (var item in extratoDeTransacoes) {
                if (item != null) {
                    totalCredito += item.ValorCredito;
                }
            }
            foreach (var item in extratoDeDepositos) {
                if (item != null) {
                    totalDebito += item.ValorDeposito;
                }
            }
            double saldoAtual = totalDebito - totalCredito;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.WriteLine ($"O seu saldo atual é de: {saldoAtual}");
            Console.ResetColor ();

        }
        public static void Zipar () {
            string startPath = @".\start";
            string zipPath = @".\BancoDeDados.zip";
            string extractPath = @".\extract";

            ZipFile.CreateFromDirectory (startPath, zipPath);

            ZipFile.ExtractToDirectory (zipPath, extractPath);
        }

    }
}