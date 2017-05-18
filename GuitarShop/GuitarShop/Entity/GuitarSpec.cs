using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarShop.Abstract;

namespace GuitarShop.Entity
{
    public class GuitarSpec : InstrumentSpec
    {
        public int NumString { get; private set; }

        public GuitarSpec(Abstract.Type type, string model, Builder builder, Wood topWood, Wood backWood, int numString)
            : base(type, model, builder, topWood, backWood)
        {
            this.NumString = numString;
        }

        public override bool IsMatch(InstrumentSpec searchSpec)
        {
            if (!base.IsMatch(searchSpec))
                return false;
            if (!(searchSpec is GuitarSpec))
                return false;

            GuitarSpec spec = searchSpec as GuitarSpec;
            if (NumString != spec.NumString)
                return false;

            return true;
        }
    }
}
