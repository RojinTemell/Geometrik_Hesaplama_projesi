using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrik_hesaplama_projesi
{
    public abstract class Geometrik_hesaplamalar
    {
        protected double cevre;
        public double Cevre { get; private set; }

        protected double alan;
        public double Alan { get; private set; }

        public abstract double Cevre_hesapla(double a1, double a2);

        public abstract double Alan_hesapla(double a1, double a2);

    }
}
