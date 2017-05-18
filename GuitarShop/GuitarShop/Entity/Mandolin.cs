using GuitarShop.Abstract;

namespace GuitarShop.Entity
{
    public class Mandolin : Instrument
    {
        public Mandolin(string serialNumber, double price, MandolinSpec spec) : base(serialNumber, price, spec)
        {
        }
    }
}
