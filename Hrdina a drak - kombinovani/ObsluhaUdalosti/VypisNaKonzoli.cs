using Hrdina_a_drak___kombinovani.Postavy;
using Hrdina_a_drak___kombinovani.Rozhrani;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrdina_a_drak___kombinovani.ObsluhaUdalosti
{
    internal class VypisNaKonzoli
    {
        public static void VypisUtoku(double utok, Postava postava, IZasazitelny zasazitelnaEntita)
        {
            Console.WriteLine($"{postava.Jmeno} zaútočil hodnotou: {utok}, zasažený objekt má zdraví: {zasazitelnaEntita.ZdraviAktualni}");
        }
    }
}
