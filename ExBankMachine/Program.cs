using System;

namespace ExBankMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            /*******************************************
                            SAQUE CERTO!
            ********************************************/

            int[] notas = { 1, 2, 5, 10, 20, 50, 100 };
            System.Console.Write ("Digite o valor do seu saque: ");

            int saque = int.Parse (Console.ReadLine ());
            DateTime data = DateTime.Now;
            //============================================
            //    Usando o for regressivo
            //============================================
            for (int i = notas.Length - 1; i >= 0  ; i--) {
                
                int qntdNotas = saque / notas[i];
                int restante = saque % notas[i];
                saque = restante;

                if(qntdNotas != 0) {
                    System.Console.WriteLine($" Você recebeu {qntdNotas} nota(s) de {notas[i]} em {data:HH:mm}");
                }

            }

            /* 
            //============================================
            //    Usando o for progressivo
            //============================================

            System.Console.Write ("Digite o valor que deseja sacar:");
            int saque = int.Parse (Console.ReadLine ());
            DateTime data = DateTime.Now;

            for (int i = 0; i < notas.Length; i++) {
                int qntdNotas = saque / notas[i];
                int excedente = saque % notas[i];
                saque = excedente;

                if (qntdNotas != 0)
                {
                    System.Console.WriteLine ($"Você recebeu:{qntdNotas} em notas de {notas[i]} em {data:HH:mm}");
                }

            }
            */
            
        }
    }
}
