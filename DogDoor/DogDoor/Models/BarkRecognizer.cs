using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoor.Models
{
    internal class BarkRecognizer
    {
        private DogDoor door;

        public BarkRecognizer(DogDoor door)
        {
            this.door = door;
        }

        public void Recognize(Bark bark)
        {
            if (door.GetAllowedBarks().Contains(bark))
            {
                Console.WriteLine("BarkRecognizer: Usłyszano '" + bark.GetSound() + "'");
                door.Open();
            }
        }
    }
}
