using Hrdina_a_drak___kombinovani.Postavy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrdina_a_drak___kombinovani.Bojiste
{
    internal class Arena
    {
        public Hrdina Hrdina { get; set; }
        public Drak Drak { get; set; }

        public Arena(Hrdina hrdina, Drak drak)
        {
            Hrdina = hrdina;
            Drak = drak;
        }

        public void Boj()
        {
            //TODO
        }
    }
}
