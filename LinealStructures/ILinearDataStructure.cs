using System;
using System.Collections.Generic;
using System.Text;

namespace LinealStructures
{
    interface ILinearDataStructure<T>
    {
        void Add(T value);
        bool Find(T value);
    }
}
