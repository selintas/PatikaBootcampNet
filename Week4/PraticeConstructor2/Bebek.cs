using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeConstructor2
{
    public class Bebek
    {
        // Properties
        public DateTime DogumTarihi { get; private set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        // 1. Default Constructor (Parametresiz)
        public Bebek()
        {
            DogumTarihi = DateTime.Now;
            Console.WriteLine("Ingaaaa");
        }

        // 2. Constructor with Ad and Soyad parameters
        public Bebek(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
            DogumTarihi = DateTime.Now;
            Console.WriteLine("Ingaaaa");
        }
    }
}
