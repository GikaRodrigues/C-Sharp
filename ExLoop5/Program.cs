using System;

namespace ExLoop5
{
    class Program
    {
        static void Main(string[] args)
        {
            int linhas = 2;
            int colunas = 2;

            for (int i = 0; i <= linhas; i++) { 
                for (int j = 0; j < colunas; j++) { 
                   System.Console.WriteLine($"[{i},{j}]");

                } 
            }
        }
    }
}