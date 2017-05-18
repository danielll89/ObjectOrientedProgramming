using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop.Model
{
    public class Mandolin : Instrument
    {
        public Mandolin(string serialNumber, double price, MandolinSpec spec) : base(serialNumber, price, spec)
        {
        }
    }
}
