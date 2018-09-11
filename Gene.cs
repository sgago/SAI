
namespace SAI.GA
{
    public interface IGene<T>
    {
        T Value { get; set; }

        //Gene<T> Clone();
    }

    public abstract class Gene<T> : IGene<T>
    {
        private T value = default(T);

        public T Value { get; set; }

        //public Gene()
        //{
        //    Value = Initialize();
        //}

        //public Gene(Gene<T> gene)
        //{
        //    Value = gene.Value;
        //}

        //public Gene()
        //{
        //    Value = Initialize();
        //}

        //protected Gene(T value)
        //{
        //    Value = value;
        //}

        //public abstract Gene<T> Clone();

        public abstract T Initialize();

        public abstract Gene<T> DeepClone();

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
