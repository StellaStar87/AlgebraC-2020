using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Domaci_Rad_Objekti
{
    class Kolac
    {
        private List<int> MasaSastojaka = new List<int>();
        private List<string> ImenaSastojaka = new List<string>();
        private Boolean kolacIspecen = false;
        public Boolean KolacIspecen { get => kolacIspecen; set => kolacIspecen = value; }

        internal void DodajSastojak(string v1, int v2)
        {
            if (kolacIspecen == false)
            {
                MasaSastojaka.Add(v2);
                ImenaSastojaka.Add(v1);
            }
            else
            {
                Console.WriteLine("Kolač je ispečen, ne može se dodati više sastojaka!!");
            }
        }

        internal double IzracunajMasu()
        {
            double sum_all = (double)MasaSastojaka.Sum();
            double sum_all_kg = (double)sum_all / 1000;
            return sum_all_kg;
        }
        public override string ToString() { 
        string String1;
        string String2;
        string String3;
            if (kolacIspecen == true)
            {
                String1 = "Kolač je pečen!";
            }
            else
            {
                String1 = "Kolač nije još pečen.";
            }

            //ImenaSastojaka.ForEach(Console.WriteLine);
            String2 = "Sastojci su:" + String.Join(",", ImenaSastojaka);
           
            String3 = "Masa kolača je " + IzracunajMasu().ToString("0.00");
            return String1 + Environment.NewLine + String2 + Environment.NewLine + String3;
                }

        
    }
}
   