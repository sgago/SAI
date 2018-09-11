
using System;

namespace SAI.GA
{
    public class NumericChromosome : Chromosome<double>
    {
        public NumericChromosome()
        {

        }

        public NumericChromosome(int length, double minValue = double.MinValue, double maxValue = double.MaxValue)
        {
            IGene<double> newGene = new NumericGene(minValue, maxValue);

            if (length < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(length),
                                                      "Length of a chromosome cannot be less than 1.");
            }

            for (int i = 0; i < length; i++)
            {
                Add(newGene);
            }
        }

        public new NumericChromosome DeepClone()
        {
            NumericChromosome clone = new NumericChromosome();

            foreach (NumericGene gene in this)
            {
                clone.Add(new NumericGene(gene));
            }

            return clone;
        }

        public override string ToString()
        {
            // FIXME: I don't concat list elements in a way that looks pretty.
            //return string.Join(",", this);
            //this.

            // FIXME: Long chromosomal sequences may be better
            // served by a string builder
            string result = "[";

            for (int i = 0; i < Count - 1; i++)
            {
                result += this[i].Value + ",";
            }

            result += this[Count - 1].Value + "]";

            return result;
        }
    }
}
