using System;

namespace switch2
{
    class Program
    {
        static void Main(string[] args)
        {
             string passeio = "montanha";
            switch(passeio){
                case "montanha":
                    Console.WriteLine("Bora escalar!");
                    break;
                case "deserto":
                    Console.WriteLine("Leva uma água!");
                    break;
                case "floresta":
                    Console.WriteLine("Vai lá, Tarzan!");
                    break;
                default:
                    Console.WriteLine("Ah, então vamos para Netflix!");
                    break;
            }
        }
    }
}
