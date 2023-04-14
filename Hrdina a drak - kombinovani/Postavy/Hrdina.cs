using Hrdina_a_drak___kombinovani.Veci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrdina_a_drak___kombinovani.Postavy
{
    internal class Hrdina
    {
        public string Jmeno { get; set; }
        public double ZdraviAktualni { get; set; }
        public double ZdraviMax { get; set; }
        public int MaxUtok { get; set;}
        public int MaxObrana { get; set;}

        public Mec Mec { get; set; }

        public Hrdina(string jmeno, double zdraviAktualni, double zdraviMax, int maxUtok, int maxObrana, Mec mec)
        {
            Jmeno = jmeno;
            ZdraviAktualni = zdraviAktualni;
            ZdraviMax = zdraviMax;
            MaxUtok = maxUtok;
            MaxObrana = maxObrana;
            Mec = mec;
        }

        public Hrdina(string jmeno, double zdraviMax, int maxUtok, int maxObrana, Mec mec)
            : this(jmeno, zdraviMax, zdraviMax, maxUtok, maxObrana, mec)
        {
        }

        public void Utok()
        {
            //TODO
        }

        public void Obrana()
        {
            //TODO
        }

        public void JeZivy()
        {
            //TODO
        }
    }
}
