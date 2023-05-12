using Hrdina_a_drak___kombinovani.Nahoda;
using Hrdina_a_drak___kombinovani.Rozhrani;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrdina_a_drak___kombinovani.Postavy
{
    internal class Postava : Object, IZasazitelny
    {
        public string Jmeno { get; set; }
        public double ZdraviAktualni { get; set; }
        public double ZdraviMax { get; set; }
        public int MaxUtok { get; set; }
        public int MaxObrana { get; set; }

        protected Kostka generator = Kostka.Instance;

        public Postava(string jmeno, double zdraviAktualni, double zdraviMax, int maxUtok, int maxObrana)
        {
            Jmeno = jmeno;
            ZdraviAktualni = zdraviAktualni;
            ZdraviMax = zdraviMax;
            MaxUtok = maxUtok;
            MaxObrana = maxObrana;
        }

        public Postava(string jmeno, double zdraviMax, int maxUtok, int maxObrana)
            : this(jmeno, zdraviMax, zdraviMax, maxUtok, maxObrana)
        {
        }

        public virtual double Utok(IZasazitelny zasazitelnaEntita)
        {
            double utok = generator.NextDouble() * MaxUtok;
            utok -= zasazitelnaEntita.Obrana();

            if (utok < 0)
                utok = 0;

            zasazitelnaEntita.ZdraviAktualni -= utok;

            return utok;
        }

        public double Obrana()
        {
            return generator.NextDouble() * MaxObrana;
        }

        public bool JeZivy()
        {
            if (ZdraviAktualni > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
