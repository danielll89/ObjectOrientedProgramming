using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarShop.Model;

namespace GuitarShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            initializeInventory(inventory);

            GuitarSpec whatEveLikes = new GuitarSpec(Model.Type.ELECTRIC, "", Builder.GIBSON, Wood.ALDER, Wood.BRAZILIAN_ROSEWOOD, 6);

            List<Guitar> guitars = inventory.Search(whatEveLikes);

            if (guitars != null)
            {
                Console.WriteLine("Znaleziono!");
            }
            else
            {
                Console.WriteLine("Nie znaleziono pasujących gitar");
            }
        }

        private static void initializeInventory(Inventory inventory)
        {
            inventory.AddInstrument("1", 23.78d, new GuitarSpec(Model.Type.ELECTRIC, "LesPaul", Builder.GIBSON,   Wood.CEDAR, Wood.HEBAN, 6));
        }
    }
}
