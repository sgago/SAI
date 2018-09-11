using System.Collections.Generic;

namespace SAI.GA
{
    public abstract class RouletteWheel<T>
    {
        protected IEvaluate<T> Evaluator { get; set; } = null;
        protected IFitness<T> Fitness { get; set; } = null;

        public RouletteWheel(IEvaluate<T> evaluator,
                             IFitness<T> fitness)
        {
            Evaluator = evaluator;
            Fitness = fitness;
        }

        //public abstract IList<Chromosome<T>> Select(IList<Chromosome<T>> chromosomes);
    }
}
