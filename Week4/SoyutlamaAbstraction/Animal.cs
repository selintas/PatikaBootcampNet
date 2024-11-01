using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoyutlamaAbstraction
{
    public abstract class Animal // Abstract sınıf: Hayvan (Animal)
    {
        public string Name { get; set; }

        // Soyut (abstract) metot: SesCikar (MakeSound)
        public abstract void MakeSound();

        // Somut (concrete) metot: BilgiYazdir (PrintInfo)
        public void PrintInfo()
        {
            Console.WriteLine($"Bu hayvanın adı: {Name}");
        }  
    }

    // Türetilmiş sınıf: Köpek (Dog), Hayvan sınıfından kalıtım alır
    public class Dog : Animal
    {
        // MakeSound metodu override edilir
        public override void MakeSound()
        {
            Console.WriteLine("Hav! Hav!");
        }
    }

    // Türetilmiş sınıf: Kedi (Cat), Hayvan sınıfından kalıtım alır
    public class Cat : Animal
    {
        // MakeSound metodu override edilir
        public override void MakeSound()
        {
            Console.WriteLine("Miyav!");
        }
    }
}
