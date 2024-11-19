using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasicQueryV
{
    public class Person : IComparable<Person> //ınterface kullanma sıralam ıcın
    { 
        public int Id { get; set; } //oto property
        public int Age { get; set; }
        public string Name { get; set; }
         
        public int CompareTo(Person? other) 
        {
            int result = 0;

            if (Id > other.Id)
                result = 1;
             else if (Id < other.Id)
                result = -1;

            return result;
        }

        //override
        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
