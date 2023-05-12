using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrdina_a_drak___kombinovani.Postavy
{
    internal class Vlk : Postava
    {
        public Vlk(string jmeno, double zdraviAktualni, double zdraviMax, int maxUtok, int maxObrana)
            : base(jmeno, zdraviAktualni, zdraviMax, maxUtok, maxObrana)
        {
        }

        public Vlk(string jmeno, double zdraviMax, int maxUtok, int maxObrana)
            : base(jmeno, zdraviMax, maxUtok, maxObrana)
        {
        }
    }
}
