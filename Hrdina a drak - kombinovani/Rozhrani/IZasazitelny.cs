using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrdina_a_drak___kombinovani.Rozhrani
{
    internal interface IZasazitelny
    {
        double Obrana();
        double ZdraviAktualni { get; set; }
    }
}
