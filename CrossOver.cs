using SAI.GA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAI
{
    interface ICrossOver<T>
    {
        void Cross(IList<T> chromosome1, IList<T> chromosome2);
    }

    public class CrossOver<T> : ICrossOver<T>
    {
        public void Cross(IList<T> chromosome1, IList<T> chromosome2)
        {
            throw new NotImplementedException();
        }
    }
}
