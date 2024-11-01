using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterfaceV
{ 
   //poly
    public interface IPrintable
    {
        void Print(); 
    } 
     
    public interface ISavable
    {
        void save();
    }
    public class Document : IPrintable, ISavable // bırden fazla ınterface alabılır.
    {
        public void Print()
        {
            Console.WriteLine("print");
        }

        public void save()
        {
            Console.WriteLine("save");
        }
    }
}
