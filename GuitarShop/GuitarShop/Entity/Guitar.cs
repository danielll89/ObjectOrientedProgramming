using GuitarShop.Abstract;

namespace GuitarShop.Entity
{
    public class Guitar : Instrument
    {
        public Guitar(string serialNumber, double price, GuitarSpec spec) : base (serialNumber, price, spec)
        {
        }
    }
}
