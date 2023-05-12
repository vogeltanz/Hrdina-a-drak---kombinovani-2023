using Hrdina_a_drak___kombinovani.Veci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrdina_a_drak___kombinovani.Postavy
{
    internal class Hrdina : Postava
    {
        public Mec Mec { get; set; }

        public Hrdina(string jmeno, double zdraviAktualni, double zdraviMax, int maxUtok, int maxObrana, Mec mec)
            : base(jmeno, zdraviAktualni, zdraviMax, maxUtok, maxObrana)
        {
            Mec = mec;
        }

        public Hrdina(string jmeno, double zdraviMax, int maxUtok, int maxObrana, Mec mec)
            : this(jmeno, zdraviMax, zdraviMax, maxUtok, maxObrana, mec)
        {
        }

        public override double Utok(Postava postava)
        {
            double utok = 0;
            if (Mec != null)
            {
                utok = generator.NextDouble() * Mec.MaxUtok;
                utok -= postava.Obrana();

                if (utok < 0)
                    utok = 0;

                postava.ZdraviAktualni -= utok;
            }
            else
            {
                //vyuziti metody z rodicovske tridy
                base.Utok(postava);
            }

            return utok;
        }
    }
}
