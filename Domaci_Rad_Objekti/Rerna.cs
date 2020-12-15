using System;
using System.Collections.Generic;
using System.Text;

namespace Domaci_Rad_Objekti
{
    static class Rerna
    {
        internal static int BrojIspecenihKolaca = 0;
        
        internal static void Ispeci(ref Kolac a)
        {
            a.KolacIspecen = true;
            BrojIspecenihKolaca += 1;
        }
    }
}

