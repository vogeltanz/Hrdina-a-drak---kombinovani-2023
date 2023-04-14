using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrdina_a_drak___kombinovani.Postavy
{
    internal class Drak
    {
        public string Jmeno { get; set; }
        public double ZdraviAktualni { get; set; }
        public double ZdraviMax { get; set; }
        public int MaxUtok { get; set; }
        public int MaxObrana { get; set; }

        public Drak(string jmeno, double zdraviAktualni, double zdraviMax, int maxUtok, int maxObrana)
        {
            Jmeno = jmeno;
            ZdraviAktualni = zdraviAktualni;
            ZdraviMax = zdraviMax;
            MaxUtok = maxUtok;
            MaxObrana = maxObrana;
        }

        public Drak(string jmeno, double zdraviMax, int maxUtok, int maxObrana)
        {
            Jmeno = jmeno;
            ZdraviAktualni = zdraviMax;
            ZdraviMax = zdraviMax;
            MaxUtok = maxUtok;
            MaxObrana = maxObrana;
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
