using PraticeConstructor2;
using System;

namespace PraticeConstructor2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Default constructor kullanımı 
           
            Bebek bebek1 = new Bebek();

            Console.WriteLine($"Bebek 1 Doğum Tarihi: {bebek1.DogumTarihi}");

            // Parametreli constructor kullanımı
            Bebek bebek2 = new Bebek("Ali", "TAŞ");

            Console.WriteLine($"Bebek 2 Adı: {bebek2.Ad}, Soyadı: {bebek2.Soyad}, Doğum Tarihi: {bebek2.DogumTarihi}");
        }
    }
}