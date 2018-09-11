
namespace SAI.GA
{
    public interface IEvaluate<T>
    {
        T Evaluate(Chromosome<T> chromosome);
    }
}
