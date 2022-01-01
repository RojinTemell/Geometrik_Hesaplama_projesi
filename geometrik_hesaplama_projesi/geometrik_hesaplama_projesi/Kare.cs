using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrik_hesaplama_projesi
{
  public   class Kare: Geometrik_hesaplamalar
    {
        public override double Cevre_hesapla(double a1, double a2)
        {
            a1 = a2;
            cevre = 4 * a1;
            return cevre;
        }
        public override double Alan_hesapla(double a1, double a2)
        {
            a1 = a2;
            alan = a1 * a1;
            return alan;

        }
    }
}
