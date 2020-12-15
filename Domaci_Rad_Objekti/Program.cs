using System;

namespace Domaci_Rad_Objekti
{
    class Program
    {
        static void Main(string[] args)
        {
            Kolac K1 = new Kolac();
            K1.DodajSastojak("Margarin", 200);
            K1.DodajSastojak("Šećer", 100);
            K1.DodajSastojak("Čokolada", 300);
            K1.DodajSastojak("Jaje", 50);
            Rerna.Ispeci(ref K1);
            
            Kolac K2 = new Kolac();
            K2.DodajSastojak("Margarin", 230);
            K2.DodajSastojak("Šećer", 400);
            K2.DodajSastojak("Čokolada", 30);
            K2.DodajSastojak("Jaje", 10);
            Rerna.Ispeci(ref K2);
            
            Console.WriteLine(K1);
            Console.WriteLine(K2);
            K1.DodajSastojak("Limun", 100);
            Console.WriteLine("Broj ispečenih kolača je " + Rerna.BrojIspecenihKolaca.ToString());





        }
    }
}
