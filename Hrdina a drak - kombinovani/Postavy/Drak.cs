using Hrdina_a_drak___kombinovani.Rozhrani;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrdina_a_drak___kombinovani.Postavy
{
    internal class Drak : Postava
    {
        public Drak(string jmeno, double zdraviAktualni, double zdraviMax, int maxUtok, int maxObrana, IRandom generator)
            : base(jmeno, zdraviAktualni, zdraviMax, maxUtok, maxObrana, generator)
        {
        }

        public Drak(string jmeno, double zdraviMax, int maxUtok, int maxObrana, IRandom generator)
            : base(jmeno, zdraviMax, maxUtok, maxObrana, generator)
        {
        }
    }
}
