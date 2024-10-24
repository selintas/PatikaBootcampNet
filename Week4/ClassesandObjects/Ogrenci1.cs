using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesandObjects
{
    public class Ogrenci1 // Örnek Sınıf Tasarımı
    {
        // Alan (field)
        public string Ad; // Ogrenci'nin adi

        // Metod
        public void SelamVer()
        {
            Console.WriteLine("Merhaba, ben " + Ad + "!");
        }
    }
}
