namespace GuitarShop.Abstract
{
    public abstract class Instrument
    {
        public string SerialNumber { get; private set; }
        public double Price { get; private set; }
        public InstrumentSpec Spec { get; set; }

        public Instrument(string serialNumber, double price, InstrumentSpec spec)
        {
            this.SerialNumber = serialNumber;
            this.Price = price;
            this.Spec = spec;
        }
    }    
}
