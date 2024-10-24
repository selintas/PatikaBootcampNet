using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesFieldsMethods
{
    public class Ogrenci2
    {
        private string isim; // Field: Ogrenci'nin ismi

        public string Isim // Property: Ogrenci ismi için property 
                           //Property'ler, field'ların dışarıdan erişimini kontrol eder ve bu erişim sırasında ek mantıksal işlemler yapabilirler.
        {
            get { return isim; } // Isim'in değerini döndür
            set { isim = value; } // Isim'e değer atama 
            //get ve set erişim metotları ile tanımlanır. get metodu property'nin değerini döndürür, set metodu ise property'ye değer atar.
        }
    }
}
