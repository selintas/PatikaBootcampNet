using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalıtımMirasAlma_Inheritance_
{
    public class Animal // Ana sınıf (base class)
    {
        public void Eat()
        {
            Console.WriteLine("The animal is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine("The animal is sleeping.");
        }
    }

    public class Dog : Animal // Türetilmiş sınıf (derived class)
    {
        public void Bark()
        {
            Console.WriteLine("The dog is barking.");
        }
    }
}
