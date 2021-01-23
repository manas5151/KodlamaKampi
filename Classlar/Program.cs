using System;

namespace Classlar
{
    class Program
    {
        static void Main(string[] args)
        {
            DaireOzellikleri daire1 = new DaireOzellikleri();
            daire1.Tipi = "4+1";
            daire1.OdaSayisi = "5 oda";
            daire1.MetreKaresi = 150.45;
            daire1.Kati = "5.normal kat";

            DaireOzellikleri daire2 = new DaireOzellikleri();
            daire2.Tipi = "3+1";
            daire2.OdaSayisi = "5 oda";
            daire2.MetreKaresi = 140.00;
            daire2.Kati = "4.normal kat";

            DaireOzellikleri daire3 = new DaireOzellikleri();
            daire3.Tipi = "2+1";
            daire3.OdaSayisi = "3 oda";
            daire3.MetreKaresi = 120.00;
            daire3.Kati = "1.normal kat";

            DaireOzellikleri[] Satıstaki = new DaireOzellikleri[] {daire1,daire2,daire3 };

            foreach (DaireOzellikleri Stoktaki in Satıstaki)

            {
                Console.WriteLine(Stoktaki.Tipi);
                Console.WriteLine(Stoktaki.OdaSayisi);
                Console.WriteLine(Stoktaki.MetreKaresi);
                Console.WriteLine(Stoktaki.Kati);
                Console.WriteLine("----------");
            }

            SepetManager SatilanDaireler = new SepetManager();
            SatilanDaireler.Ekle(daire1);
            SatilanDaireler.Ekle(daire2);
            SatilanDaireler.Ekle(daire3);

            Console.WriteLine("------------Metodlar Son-----------");





        }

    }
}
