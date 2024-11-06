using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethodsV2
{
    public class GenericClassV<T> 

    { 
        private T _field;  

        public GenericClassV(T value)
        {
            _field = value;
        }
         
        public T GetValue() { return _field; }
    }
}
