using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string daireTipi1 = "4+1 Daire";
            string daireTipi2 = "3+1 Daire";
            string daireTipi3 = "2+1 Daire";
            string daireTipi4 = "1+1 Daire";
            string daireTipi5 = "Loft Daire";

            string[] daireTipleri = new string[] { daireTipi1, daireTipi2, daireTipi3,daireTipi4,daireTipi5 };

            for (int i = 0; i < daireTipleri.Length ; i++)
            {
                Console.WriteLine(daireTipleri[i]);
            }

            Console.WriteLine("------For Döngüsü Bitti------" );

            foreach (string daireler in daireTipleri)
            {
                Console.WriteLine(daireler);
            }
            Console.WriteLine("------Foreach Döngüsü Bitti----");
        }
    }
}
