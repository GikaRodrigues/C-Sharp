using System;

namespace ExEstrela2
{
    class Program
    {
        static void Main(string[] args)
        {
            string estrela = "";

            for (int i = 0; i <= 3; i++){
                estrela = "";
                for (int j = 0; j <= 10; j++){
                    estrela += "*";
                    Console.WriteLine(estrela);
                }
            }
        }
    }
}
