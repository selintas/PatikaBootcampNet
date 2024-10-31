using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratikPolymorphism
{
    public class BaseGeometrikSekil // Base class (Temel sınıf)
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        // Alan hesaplama metodu - Geometrik şekillerde override edilmesi için sanal metot
        public virtual double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    }

    // Kare sınıfı - BaseGeometrikSekil sınıfından türetilmiş
    public class Kare : BaseGeometrikSekil
    {
        // Alan hesaplama metodu - Genişlik * Yükseklik (Base class yöntemi ile aynı)
        public override double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    }

    // Dikdörtgen sınıfı - BaseGeometrikSekil sınıfından türetilmiş
    public class Dikdortgen : BaseGeometrikSekil
    {
        // Alan hesaplama metodu - Genişlik * Yükseklik (Base class yöntemi ile aynı)
        public override double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    }

    // Dik Üçgen sınıfı - BaseGeometrikSekil sınıfından türetilmiş
    public class DikUcgen : BaseGeometrikSekil
    {
        // Alan hesaplama metodu - Genişlik * Yükseklik / 2
        public override double AlanHesapla()
        {
            return (Genislik * Yukseklik) / 2; // metot override edip metot returnde değişkilk yaptık.
        }
    }


}
