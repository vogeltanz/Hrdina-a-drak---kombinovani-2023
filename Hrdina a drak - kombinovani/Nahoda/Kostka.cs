using Hrdina_a_drak___kombinovani.Rozhrani;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrdina_a_drak___kombinovani.Nahoda
{
    internal class Kostka : Random, IRandom
    {
        private static Kostka instance;
        public static Kostka Instance
        {
            get
            {
                if(instance == null)
                    instance = new Kostka();

                return instance;
            }
        }
        private Kostka()
        {
        }
    }
}
