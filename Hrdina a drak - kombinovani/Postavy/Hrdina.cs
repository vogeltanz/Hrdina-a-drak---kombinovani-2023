﻿using Hrdina_a_drak___kombinovani.Rozhrani;
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

        public Hrdina(string jmeno, double zdraviAktualni, double zdraviMax, int maxUtok, int maxObrana, Mec mec, IRandom generator)
            : base(jmeno, zdraviAktualni, zdraviMax, maxUtok, maxObrana, generator)
        {
            Mec = mec;
        }

        public Hrdina(string jmeno, double zdraviMax, int maxUtok, int maxObrana, Mec mec, IRandom generator)
            : this(jmeno, zdraviMax, zdraviMax, maxUtok, maxObrana, mec, generator)
        {
        }

        public override double Utok(IZasazitelny zasazitelnaEntita)
        {
            double utok = 0;
            if (Mec != null)
            {
                utok = generator.NextDouble() * Mec.MaxUtok;
                utok -= zasazitelnaEntita.Obrana();

                if (utok < 0)
                    utok = 0;

                zasazitelnaEntita.ZdraviAktualni -= utok;

                VyvolaniUdalostiZautocil(utok, zasazitelnaEntita);
            }
            else
            {
                //vyuziti metody z rodicovske tridy
                base.Utok(zasazitelnaEntita);
            }

            return utok;
        }
    }
}
