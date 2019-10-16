using System;

namespace Negozio_es11
{
    class Program
    {
        static void Main(string[] args)
        {
            double prezzofinale = 0;
            Console.Write("Quanto ha speso? ");
            double tot = double.Parse(Console.ReadLine());
            if(tot < 500)
            {
                Console.WriteLine("Applico uno sconto del 10%");
                double sconto10 = (tot / 100) * 10;
                prezzofinale = tot - sconto10;
                Console.WriteLine($"Il prezzo scontato da pagare è: {prezzofinale} euro considerando lo sconto di {sconto10} euro");

            }
            if (tot > 500)
            {
                Console.WriteLine("Applico uno sconto del 20% ");
                double sconto20 = (tot / 100) * 20;
                prezzofinale = tot - sconto20;
                Console.WriteLine($"Il prezzo scontato da pagare è: {prezzofinale} euro considerando lo sconto di {sconto20} euro");
            }
            Console.ReadLine();
        }
    }
}
