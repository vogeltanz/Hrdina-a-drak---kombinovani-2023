using Hrdina_a_drak___kombinovani.Nabytek;
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
        public Postava Postava1 { get; set; }
        public Postava Postava2 { get; set; }

        public Arena(Postava postava1, Postava postava2)
        {
            Postava1 = postava1;
            Postava2 = postava2;
        }

        public void Boj()
        {
            using (StreamWriter streamWriter = File.CreateText("zaznam boje.txt"))
            {
                Bedna bedna = new Bedna(20);
                while (Postava1.JeZivy() && Postava2.JeZivy())
                {
                    double utok = Postava1.Utok(Postava2);
                    Console.WriteLine($"{Postava1.Jmeno} zaútočil hodnotou: {utok}");
                    streamWriter.WriteLine($"{Postava1.Jmeno} zaútočil hodnotou: {utok}");

                    utok = Postava1.Utok(bedna);
                    Console.WriteLine($"{Postava1.Jmeno} rozbijí bednu útokem: {utok}");
                    streamWriter.WriteLine($"{Postava1.Jmeno} rozbijí bednu útokem: {utok}");

                    if (Postava2.JeZivy())
                    {
                        utok = Postava2.Utok(Postava1);
                        Console.WriteLine($"{Postava2.Jmeno} zaútočil hodnotou: {utok}");
                        streamWriter.WriteLine($"{Postava2.Jmeno} zaútočil hodnotou: {utok}");

                        utok = Postava2.Utok(bedna);
                        Console.WriteLine($"{Postava2.Jmeno} rozbijí bednu útokem: {utok}");
                        streamWriter.WriteLine($"{Postava2.Jmeno} rozbijí bednu útokem: {utok}");
                    }
                }
            }
        }

        public void VypisViteze()
        {
            if(Postava1.JeZivy() && Postava2.JeZivy())
            {
                Console.WriteLine("Boj nemá vítěze!");
            }
            else if(Postava1.JeZivy())
            {
                Console.WriteLine($"{Postava1.Jmeno} zvítězil!");
            }
            else
            {
                Console.WriteLine($"{Postava2.Jmeno} zvítězil!");
            }
        }
    }
}
