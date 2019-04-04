using System;

namespace Do
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contando");

           int aumento = 0;

           do
           {

               Console.WriteLine("o valor atual do aumento:"+aumento);
               aumento += 1;

           } while (aumento <= 10000);
        }
    }
}
