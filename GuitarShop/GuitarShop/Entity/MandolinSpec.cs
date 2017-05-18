using GuitarShop.Abstract;

namespace GuitarShop.Entity
{
    public class MandolinSpec : InstrumentSpec
    {
        public Style Style { get; private set; }

        public MandolinSpec(Type type, string model, Builder builder, Wood topWood, Wood backWood, Style style) 
            : base(type, model, builder, topWood, backWood)
        {
            this.Style = style;
        }

        public override bool IsMatch(InstrumentSpec searchSpec)
        {
            if (!base.IsMatch(searchSpec))
                return false;
            if (!(searchSpec is MandolinSpec))
                return false;

            MandolinSpec spec = searchSpec as MandolinSpec;
            if (Style != spec.Style)
                return false;

            return true;
        }
    }
}
