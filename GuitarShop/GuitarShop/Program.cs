using System;
using System.Collections.Generic;
using GuitarShop.Abstract;
using GuitarShop.Entity;
using GuitarShop.Model;

namespace GuitarShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            initializeInventory(inventory);

            GuitarSpec whatEveLikes = new GuitarSpec(Abstract.Type.ELECTRIC, "", Builder.GIBSON, Wood.ALDER, Wood.BRAZILIAN_ROSEWOOD, 6);

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
            inventory.AddInstrument("1", 23.78d, new GuitarSpec(Abstract.Type.ELECTRIC, "LesPaul", Builder.GIBSON,   Wood.CEDAR, Wood.HEBAN, 6));
        }
    }
}
