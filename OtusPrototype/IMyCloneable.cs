using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusPrototype
{
    public interface IMyCloneable <T> 
    {
        T ShallowCopy();
        T DeepClone();
    }
}
