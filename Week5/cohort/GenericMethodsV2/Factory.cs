using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethodsV2
{
    public class Factory<T> where T : new() 
    {
        public T CreateInstance()
        { 
            return new T();

        }
    }
    
}
