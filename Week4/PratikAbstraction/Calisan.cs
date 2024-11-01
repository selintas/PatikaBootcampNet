using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratikAbstraction
{
    public abstract class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }

        // Abstract metot: Görev
        public abstract void Gorev();
    }
      // YazilimGelistirici sınıfı, Calisan sınıfından türetilmiştir
    public class YazilimGelistirici : Calisan
    {
        public override void Gorev()
        {
            Console.WriteLine("Yazılım geliştirici olarak çalışıyorum.");
        }
    }
    // ProjeYoneticisi sınıfı, Calisan sınıfından türetilmiştir
    public class ProjeYoneticisi : Calisan
    {
        public override void Gorev()
        {
            Console.WriteLine("Proje yöneticisi olarak çalışıyorum.");
        }
    }
    // SatisTemsilcisi sınıfı, Calisan sınıfından türetilmiştir
    public class SatisTemsilcisi : Calisan
    {
        public override void Gorev()
        {
            Console.WriteLine("Satış temsilcisi olarak çalışıyorum.");
        }
    }
}
