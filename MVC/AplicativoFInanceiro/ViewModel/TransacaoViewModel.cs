using System;
namespace AplicativoFInanceiro.ViewModel
{
    public class TransacaoViewModel
    {
       public string Descricao {get;set;}
       public DateTime DataDaTransacao {get;set;}
       public double ValorDeposito {get;set;}
       public double ValorCredito {get;set;}

    }
}