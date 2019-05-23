using System;

namespace ExFor
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Quantas estrelas desejas na base da piramide de gizé?");
            int tamanhoTriangulo = int.Parse(Console.ReadLine());
            string estrela = "";

            for (int i = 0; i < tamanhoTriangulo; i++)
            {
                estrela += "*";
                Console.WriteLine(estrela);
            }
        }
    }
}
