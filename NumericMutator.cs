using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAI.GA
{
    class NumericMutator : IMutator<NumericChromosome>
    {
        public double MutationRate { get; set; } = 0.0d;

        public NumericMutator(double mutationRate)
        {
            MutationRate = mutationRate;
        }

        public IList<NumericChromosome> Mutate(IList<NumericChromosome> population)
        {
            foreach (NumericChromosome chromosome in population)
            {
                foreach (NumericGene gene in chromosome)
                {
                    if (Randomizer.Double() <= MutationRate)
                    {
                        gene.Initialize();
                    }
                }
            }

            return population;
        }
    }
}
