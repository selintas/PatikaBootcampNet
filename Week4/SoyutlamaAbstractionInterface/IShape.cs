using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoyutlamaAbstractionInterface
{
    public interface IShape // Interface: IShape (Şekil) ınterfacelerin basına I yazılır.
    {
        double CalculateArea(); // Alanı hesaplamak için soyut (abstract) metot -metot içeriği başka sınıfta classda.
    }


    public class Circle : IShape // Daire (Circle) sınıfı, IShape arayüzünü uygular
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        // IShape arayüzünden gelen metot, Circle sınıfında implement edilir
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    
    public class Square : IShape // Kare (Square) sınıfı, IShape arayüzünü uygular
    {
        public double SideLength { get; set; }

        public Square(double sideLength)
        {
            SideLength = sideLength;
        }

        // IShape arayüzünden gelen metot, Square sınıfında implement edilir
        public double CalculateArea()
        {
            return SideLength * SideLength;
        }
    }

}
