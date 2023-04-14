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
            while (Hrdina.JeZivy() && Drak.JeZivy())
            {
                double utok = Hrdina.Utok(Drak);
                Console.WriteLine($"{Hrdina.Jmeno} zaútočil hodnotou: {utok}");

                if (Drak.JeZivy())
                {
                    utok = Drak.Utok(Hrdina);
                    Console.WriteLine($"{Drak.Jmeno} zaútočil hodnotou: {utok}");
                }
            }
        }

        public void VypisViteze()
        {
            if(Hrdina.JeZivy() && Drak.JeZivy())
            {
                Console.WriteLine("Boj nemá vítěze!");
            }
            else if(Hrdina.JeZivy())
            {
                Console.WriteLine($"{Hrdina.Jmeno} zvítězil!");
            }
            else
            {
                Console.WriteLine($"{Drak.Jmeno} zvítězil!");
            }
        }
    }
}
