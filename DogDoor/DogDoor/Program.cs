using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DogDoor.Models;

namespace DogDoor
{
    class Program
    {
        static void Main(string[] args)
        {
            Models.DogDoor door = new Models.DogDoor();
            door.AddAllowedBark(new Bark("hauu"));
            door.AddAllowedBark(new Bark("Hrauu"));
            door.AddAllowedBark(new Bark("hauhauu"));
            door.AddAllowedBark(new Bark("hauuuuuu"));
            BarkRecognizer recognizer = new BarkRecognizer(door);
            Remote remote = new Remote(door);

            Console.WriteLine("Azor szczeka, by wyjść na spacer...");
            Console.WriteLine();
            recognizer.Recognize(new Bark("hauu"));
   
            Console.WriteLine("Azor wyszedł na specer");
            Console.WriteLine("Azor załatwił co trzeba...");
            try
            {
                Thread.Sleep(10000);
            }
            catch(Exception ex) { }

            Console.WriteLine(".. ale Azor utknął na zewnątrz!");

            Bark smallDogBark = new Bark("hiauu");
            Console.WriteLine("Mały pies zaczął szczekać");
            recognizer.Recognize(smallDogBark);

            try
            {
                Thread.Sleep(5000);
            }
            catch (Exception ex) { }

            Console.WriteLine("\nAzor zaczyna szczekać...");
            recognizer.Recognize( new Bark("hauu"));

            Console.WriteLine("Azor wrócił do domu");

            Console.ReadLine();
        }
    }
}
