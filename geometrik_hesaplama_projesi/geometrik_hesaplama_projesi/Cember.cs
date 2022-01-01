using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrik_hesaplama_projesi
{
   public  class Cember:Geometrik_hesaplamalar
    {
        public const double PI = 3.14;
        public override double Cevre_hesapla(double a1, double a2)
        {
            a1 = a2;
            cevre = 2 * PI * a2;
            return cevre;
        }
        public override double Alan_hesapla(double a1, double a2)
        {
            a1 = a2;
            alan = PI * a2 * a2;
            return alan;

        }
    }
}
