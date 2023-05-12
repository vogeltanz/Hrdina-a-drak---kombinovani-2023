using Hrdina_a_drak___kombinovani.Rozhrani;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrdina_a_drak___kombinovani.Nabytek
{
    internal class Bedna : IZasazitelny
    {
        public double ZdraviAktualni { get; set; }

        public Bedna(double zdravi)
        {
            ZdraviAktualni = zdravi;
        }

        public double Obrana()
        {
            return 2;
        }
    }
}
