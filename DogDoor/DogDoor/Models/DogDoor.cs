using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DogDoor.Models
{
    internal class DogDoor
    {
        private bool open;
        private List<Bark> allowedBark;

        public DogDoor()
        {
            this.open = false;
            allowedBark = new List<Bark>();
        }

        public void Open()
        {
            Console.WriteLine("Dzwiczki dla psa zostały otworzone.");
            open = true;

            Timer timer = new Timer(5000);
            timer.Enabled = true;
            timer.Elapsed += (s, e) =>
            {
                Close();
                timer.Close();
            };
            timer.Start();
        }

        public void Close()
        {
            Console.WriteLine("Dzwiczki dla psa zostały zamknięte");
            open = false;
        }

        public bool IsOpen()
        {
            return open;
        }

        public void AddAllowedBark(Bark bark)
        {
            allowedBark.Add(bark);
        }

        public IEnumerable<Bark>GetAllowedBarks()
        {
            return allowedBark;
        }
    }
}
