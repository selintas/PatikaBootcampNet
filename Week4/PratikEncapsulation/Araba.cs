using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratikEncapsulation
{
    public class Araba
    { 
        public string Marka { get; set; }
        public string Model { get; set; }  
        public string Renk { get; set; }

        private int _kapiSayisi; // Kapı sayısı özelliği, kapsülleme ile kontrol ediliyor
        public int KapiSayisi
        {
            get { return _kapiSayisi; }
            //Kapı Sayısı için 2 veya 4 dışında bir değer atanmak isterse konsol ekranında bir uyarı mesajı yayınlayalım ve Kapı Sayısı değerini -1 olarak atayalım.
            set
            {
                if (value == 2 || value == 4)
                { 
                    _kapiSayisi = value;  
                }
                else  
                {
                    Console.WriteLine("Uyarı: kapı sayısı yalnızca 2 veya 4 olabılır. geçersiz"); 
                    _kapiSayisi = -1;
                }
            }
        }
        // Araba bilgilerini yazdıran metot
        public void ArabaBilgileri()
        {
            Console.WriteLine($"Marka: {Marka}, Model: {Model}, Renk: {Renk}, Kapı Sayısı: {KapiSayisi}");
        }
    }
}
