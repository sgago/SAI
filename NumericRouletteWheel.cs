using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SAI.GA
{
    public class NumericRouletteWheel : RouletteWheel<double>
    {
        public NumericRouletteWheel(IEvaluate<double> evaluator, IFitness<double> fitness)
            : base(evaluator, fitness)
        {
            
        }

        public IList<NumericChromosome> Select(IList<NumericChromosome> chromosomes)
        {
            double randomNumber = -1.0d;
            int randomIndex = -1;
            double fitnessesSum = 0.0d;
            List<double> fitnesses = new List<double>(chromosomes.Count);
            IList<double> probabilities = new List<double>(chromosomes.Count);
            IList<double> cumulativeProbabilities = new List<double>(chromosomes.Count);
            IList<NumericChromosome> newChromosomes = new List<NumericChromosome>(chromosomes.Count);

            // Calculate probabilities
            for (int i = 0; i < chromosomes.Count; i++)
            {
                fitnesses.Add(Fitness.Fitness(Evaluator.Evaluate(chromosomes[i])));
            }

            fitnessesSum = fitnesses.Sum();

            for (int i = 0; i < fitnesses.Count; i++)
            {
                probabilities.Add(fitnesses[i] / fitnessesSum);
            }

            // Calculate cumulative probabilities
            for (int i = 0; i < chromosomes.Count - 1; i++)
            {
                cumulativeProbabilities.Add(probabilities.Take(i + 1).Sum());
            }

            // Last cumulative probability is always 1
            cumulativeProbabilities[cumulativeProbabilities.Count - 1] = 1.0d;

            // For each chromosome...
            for (int i = 0; i < chromosomes.Count; i++)
            {
                // Pick a random number [0, 1)
                randomNumber = Randomizer.Double();

                // Find a the last index our random number is smaller than
                randomIndex = cumulativeProbabilities.IndexOf(cumulativeProbabilities.First(
                    x => randomNumber < x));

                newChromosomes.Add(chromosomes[randomIndex].DeepClone());
            }

            return newChromosomes;
        }
    }
}
