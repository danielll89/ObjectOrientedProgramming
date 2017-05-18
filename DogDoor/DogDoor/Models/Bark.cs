using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoor.Models
{
    internal class Bark
    {
        private string sound;

        public Bark(string sound)
        {
            this.sound = sound;
        }

        public string GetSound()
        {
            return sound;
        }

        public override bool Equals(object obj)
        {
            if (obj is Bark)
            {
                Bark bark = obj as Bark;
                return string.Compare(this.sound, bark.sound, true) == 0;
            }
            return false;
        }
    }
}
