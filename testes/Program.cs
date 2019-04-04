using System;

namespace testes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jaAcordei = false;

            do
            {
                System.Console.WriteLine("Pai, falta muito?");
                string resposta = Console.ReadLine();
                
                jaAcordei = resposta.Contains("nao") ? true : false;
            } while (!jaAcordei);
        }
    }
}
