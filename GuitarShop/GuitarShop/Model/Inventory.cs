using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarShop.Abstract;
using GuitarShop.Entity;

namespace GuitarShop.Model
{
    internal class Inventory
    {
        private List<Instrument> inventory = new List<Instrument>();

        public void AddInstrument(string serialNumber, double price, InstrumentSpec spec)
        {
            Instrument instrument = null;

            if (spec is GuitarSpec)
            {
                instrument = new Guitar(serialNumber, price, (GuitarSpec)spec);
            }
            else if (spec is MandolinSpec)
            {
                instrument = new Mandolin(serialNumber, price, (MandolinSpec)spec);
            }

            inventory.Add(instrument);
        }

        public Instrument GetInstrument(string serialNumber)
        {           
            return inventory.Where(g => g.SerialNumber == serialNumber).Single();
        }

        public List<Guitar> Search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = null;
            foreach (Guitar guitar in inventory)
            {
                if(guitar.Spec.IsMatch(searchSpec))
                    matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }

        public List<Mandolin> Search(MandolinSpec searchSpec)
        {
            List<Mandolin> matchingGuitars = null;
            foreach (Mandolin guitar in inventory)
            {
                if (guitar.Spec.IsMatch(searchSpec))
                    matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }
    }
}
