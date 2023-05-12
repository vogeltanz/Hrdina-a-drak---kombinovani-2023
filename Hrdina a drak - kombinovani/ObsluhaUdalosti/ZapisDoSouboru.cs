using Hrdina_a_drak___kombinovani.Postavy;
using Hrdina_a_drak___kombinovani.Rozhrani;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrdina_a_drak___kombinovani.ObsluhaUdalosti
{
    internal class ZapisDoSouboru
    {
        public static void Zapis(double utok, Postava postava, IZasazitelny zasazitelnaEntita)
        {
            File.AppendAllText($"zaznam boje.txt", $"{postava.Jmeno} zaútočil hodnotou: {utok}" + Environment.NewLine);

            /*
            using (StreamWriter streamWriter = File.CreateText("zaznam boje.txt"))
            {
                streamWriter.WriteLine($"{postava.Jmeno} zaútočil hodnotou: {utok}");
            }*/
        }
    }
}
