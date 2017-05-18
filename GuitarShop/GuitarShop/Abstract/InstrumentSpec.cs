using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop.Abstract
{
    public abstract class InstrumentSpec
    {
        public Type Type { get; set; }
        public string Model { get; set; }
        public Builder Builder { get; set; }
        public Wood TopWood { get; set; }
        public Wood BackWood { get; set; }

        public InstrumentSpec(Type type, string model, Builder builder, Wood topWood, Wood backWood)
        {
            this.Type = type;
            this.Model = model;
            this.Builder = builder;
            this.TopWood = topWood;
            this.BackWood = backWood;
        }

        public virtual bool IsMatch(InstrumentSpec searchSpec)
        {
            if ((searchSpec.Builder != this.Builder)
            || (searchSpec.Type != this.Type)
            || (searchSpec.TopWood != this.TopWood)
            || (searchSpec.BackWood != this.BackWood)
            || (!string.IsNullOrWhiteSpace(searchSpec.Model) && !(searchSpec.Model.ToLower() == this.Model.ToLower())))
                return false;

            return true;
        }
    }
}
