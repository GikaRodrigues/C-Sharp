using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using AplicativoFInanceiro.ViewModel;
namespace AplicativoFInanceiro.Repositorio {
    public class TransacaoRepositorio {
        
        public TransacaoViewModel InserirCredito (TransacaoViewModel credito) {
            int cont = 0;
            List<TransacaoViewModel> listaDeTransacao = Listar ();
            if (listaDeTransacao != null) {
                cont = listaDeTransacao.Count;
            }

            credito.DataDaTransacao = DateTime.Now;
            StreamWriter sw = new StreamWriter ("Transferencias.csv", true);
            sw.WriteLine ($"{credito.Descricao};{credito.ValorCredito};{credito.DataDaTransacao}");
            sw.Close ();
            return credito;
        }
        public TransacaoViewModel InserirDeposito (TransacaoViewModel credito) {
            int cont = 0;
            List<TransacaoViewModel> listaDeTransacao = ListarDeposito ();
            if (listaDeTransacao != null) {
                cont = listaDeTransacao.Count;
            }

            credito.DataDaTransacao = DateTime.Now;
            StreamWriter sw = new StreamWriter ("Depositos.csv", true);
            sw.WriteLine ($"{credito.Descricao};{credito.ValorDeposito};{credito.DataDaTransacao}");
            sw.Close ();
            return credito;
        }
        public List<TransacaoViewModel> Listar () {
            List<TransacaoViewModel> extratoDeTransacoes = new List<TransacaoViewModel> ();
            TransacaoViewModel creditoViewModel;
            if (!File.Exists ("Transferencias.csv")) {
                return null;
            }
            string[] transacoes = File.ReadAllLines ("Transferencias.csv");
            foreach (var item in transacoes) {
                if (transacoes != null) {
                    string[] dadosDeCadaTransacao = item.Split (";");
                    creditoViewModel = new TransacaoViewModel ();
                    creditoViewModel.Descricao = dadosDeCadaTransacao[0];
                    creditoViewModel.ValorCredito = double.Parse (dadosDeCadaTransacao[1]);
                    creditoViewModel.DataDaTransacao = DateTime.Parse (dadosDeCadaTransacao[2]);
                    extratoDeTransacoes.Add (creditoViewModel);

                }
            }
            return extratoDeTransacoes;
        }
        public List<TransacaoViewModel> ListarDeposito () {
            List<TransacaoViewModel> extratoDeTransacoes = new List<TransacaoViewModel> ();
            TransacaoViewModel creditoViewModel;
            if (!File.Exists ("Depositos.csv")) {
                return null;
            }
            string[] transacoes = File.ReadAllLines ("Depositos.csv");
            foreach (var item in transacoes) {
                if (transacoes != null) {
                    string[] dadosDeCadaDeposito = item.Split (";");
                    creditoViewModel = new TransacaoViewModel ();
                    creditoViewModel.Descricao = dadosDeCadaDeposito[0];
                    creditoViewModel.ValorDeposito = double.Parse (dadosDeCadaDeposito[1]);
                    creditoViewModel.DataDaTransacao = DateTime.Parse (dadosDeCadaDeposito[2]);
                    extratoDeTransacoes.Add (creditoViewModel);

                }
            }
            return extratoDeTransacoes;
        }
    }
}