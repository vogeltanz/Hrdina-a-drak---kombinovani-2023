using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrdina_a_drak___kombinovani.Postavy
{
    internal class Postava
    {
        public string Jmeno { get; set; }
        public double ZdraviAktualni { get; set; }
        public double ZdraviMax { get; set; }
        public int MaxUtok { get; set; }
        public int MaxObrana { get; set; }

        private Random generator = new Random();

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

        public double Utok(Postava postava)
        {
            double utok = generator.NextDouble() * MaxUtok;
            utok -= postava.Obrana();

            if (utok < 0)
                utok = 0;

            postava.ZdraviAktualni -= utok;

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
