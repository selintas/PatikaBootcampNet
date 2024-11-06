using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethodsV2
{
    public class GenericStack<T>
    {
        private List<T> _elements = new List<T>();

        public void Push(T item)
        { _elements.Add(item); }

        public T Pop()
        {
            if (_elements.Count == 0)
            { throw new InvalidOperationException("Stack boş"); }

            T item = _elements[_elements.Count - 1];

            _elements.RemoveAt(_elements.Count - 1);

            return item;
        }

        public T Peek()
        {
            if (_elements.Count == 0)
            { throw new InvalidOperationException("stack boş"); }
            return _elements[_elements.Count - 1];
        } 
         
        public bool IsEmpty()
            { return _elements.Count == 0; } // 0 ise true değilse false dondurur.
    }
}
