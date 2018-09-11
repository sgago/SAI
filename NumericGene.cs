using System;

namespace SAI.GA
{
    public class NumericGene : Gene<double>
    {
        public new double Value
        {
            get
            {
                return base.Value;
            }

            set
            {
                base.Value = Math.Min(Math.Max(value, MinValue), MaxValue);
            }
        }

        double MinValue { get; set; } = double.MinValue;
        double MaxValue { get; set; } = double.MaxValue;


        public NumericGene(Gene<double> gene)
        {
            Value = gene.Value;
        }

        public NumericGene(NumericGene gene)
        {
            // Min and max are being set BEFORE base constructor is called.
            // This won't work :'(  Guess we just se the value here and don't call base
            Value = gene.Value;
            MinValue = gene.MinValue;
            MaxValue = gene.MaxValue;
            
        }

        public NumericGene(double minValue = double.MinValue, double maxValue = double.MaxValue)
            : base ()
        {
            MinValue = minValue;
            MaxValue = maxValue;
            Value = Initialize();
            //Value = Randomizer.Double(MinValue, MaxValue);
        }

        /*
        public override Gene<double> Clone()
        {
            NumericGene newGene = new NumericGene();

            newGene.Value = Value;
            newGene.MinValue = MinValue;
            newGene.MaxValue = MaxValue;

            return newGene;
        }
        */

        public override double Initialize()
        {
            return Randomizer.Double(MinValue, MaxValue);
        }

        public override Gene<double> DeepClone()
        {
            return new NumericGene(this);
        }
    }
}
