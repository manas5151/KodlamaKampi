using System;
using System.Collections.Generic;
using System.Text;

namespace Classlar
{
    class SepetManager
    {
        public void Ekle(DaireOzellikleri SatilanDaireler)
        {
            Console.WriteLine("Tebrikler" + SatilanDaireler.Tipi + " Daireler Satıldı!");
            Console.WriteLine( SatilanDaireler.MetreKaresi );
            Console.WriteLine(SatilanDaireler.OdaSayisi);
            Console.WriteLine(SatilanDaireler.Kati);
            Console.WriteLine("--------------");
        }

        public void Ekle2(string Tipi, string OdaSayisi , double MetreKaresi , String Kati) 
        {
            Console.WriteLine("Tebrikler. Daireniz Satıldı : " + Tipi);
        
        
        }
        

    }
}
