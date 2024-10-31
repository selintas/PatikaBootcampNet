using PratikInheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PratikInheritance
{
    public class BaseKisi // temel base class
    { 
        public string Ad {  get; set; }
        public string Soyad { get; set; }  

        public virtual void BilgiYazdir()
        {
            Console.WriteLine($" Ad : {Ad}, Soyad : {Soyad}");
        }
    }
}
public class Ogrenci : BaseKisi // BaseKisi clasından türerilmiş derived class 
{ 
    public int OgrenciNo { get; set; }

    public void YazdirOgrenciBilgileri()
    {
        // Base sınıfın metodu çağrılıyor vırtual metot yazılacak değiştirildi.
        Console.WriteLine($"Öğrenci Numarası: {OgrenciNo}, {Ad} {Soyad}");
    }
}

public class Ogretmen : BaseKisi
{
    public decimal Maas { get; set; }
     
    //ogretmen bilgi yazdıran metot
    public void OgretmenBilgi()
    {
        // Base sınıfın metodu çağrılıyor
        BilgiYazdir();
        Console.WriteLine($"Maaş: {Maas:C}");
    }
}
    
    