using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAI.GA
{
    public interface IMutator<T>
    {
        IList<T> Mutate(IList<T> population);
    }
}
