using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokBicimlilikPolymorphism
{
    //virtual ve override keywordleriyle polymorphism'i açıklamak için bir örnek oluşturalım.
    public class GeometricShape // Ana sınıf: Geometrik Şekil (GeometricShape)
    {
        // Sanal metot: Çizim işlevi
        public virtual void Draw()
        {
            Console.WriteLine("Geometrik şekil çizildi");
        }
    }

    // Türetilmiş sınıf: Daire (Circle), Geometrik Şekil sınıfından kalıtım alır
    public class Circle : GeometricShape
    {
        // Override edilmiş metot: Çizim işlevi
        public override void Draw()
        {
            Console.WriteLine("Daire çizildi");
        }
    }

    // Türetilmiş sınıf: Kare (Square), Geometrik Şekil sınıfından kalıtım alır
    public class Square : GeometricShape
    {
        // Override edilmiş metot: Çizim işlevi
        public override void Draw()
        {
            Console.WriteLine("Kare çizildi");
        }
    }
}
