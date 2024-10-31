using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceV
{
    public abstract class Animal // Ana sınıf (base class)
    { 
        public string Name { get; set; }
        public void Eat()
        {
            Console.WriteLine($"{Name} yemek yiyor.");
        }
        public abstract void MakeSound();

        public void Sleep()
        {
            Console.WriteLine("The animal is sleeping.");
        }
    } 

    // bir sınıftan kalıtım al o kalıtımı diğer sınıflar için kullan ondan sonra kullanılan tum sınıfları etkıler
    public abstract class Mammal : Animal // abstract metottan dolayı aynı metodu overrıde yaptık kedı kopek ve kus ta
    {
        public void Nurse()
        {
            Console.WriteLine("Nursing..");
        }
    }
    public class Cat : Mammal  // Türetilmiş sınıf (derived class) - sadece bir sınıf bir sınıftan miras alır ama aldıklarını aktarır.
    {
        public override void MakeSound() //mammal dakı abstract metodu orrıve ettık. ve meow yazdık.
        {
            Console.WriteLine("Meow");
        }
        //    public void Meow()
        //{
        //    Console.WriteLine("Meow");
        //}
    }
    public class Dog : Mammal 
    {
        public override void MakeSound()
        {
            Console.WriteLine("Barking..");
        }
        //public void Bark()
        //{
        //    Console.WriteLine(" Barking");
        //}
    } 

    public class Bird : Animal
    {
        public override void MakeSound() //abstract metot kullandıktan sonra override ettik.
        {
            Console.WriteLine("...");
        }
        public void Fly()
        {
            Console.WriteLine("Flying..");
        }
    } 
    public class Sparrow : Bird
    {
        public void Sing()
        {
            Console.WriteLine("Singing..");
        }

    }
}
