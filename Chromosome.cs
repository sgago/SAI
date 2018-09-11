
using System.Collections.Generic;
using System.Linq;

namespace SAI.GA
{

    public class Chromosome<T> : List<IGene<T>>
    {
        public Chromosome<T> DeepClone()
        {
            Chromosome<T> clone = new Chromosome<T>();

            foreach (Gene<T> gene in this)
            {
                clone.Add(gene.DeepClone());
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
