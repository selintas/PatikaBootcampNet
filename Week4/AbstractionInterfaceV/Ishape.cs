//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AbstractionInterfaceV
//{
//    public interface Ishape // ınterfaec buyuk ı ile başlar.
//    {
//        void Draw();
//        double Area();
//    }

//    public class Circle : Ishape
//    { 
       
//        public double Radius { get; set; }   //propertıes 
         
//        public Circle(double radius) //ctor(parametre)
//        { 
//            Radius = radius; // tanımla boş cırcle tanımlanamaz new oluşturup parantez içine birim yazıcaz.
//        }
//        public double Area()
//        {
//            // pi * r * r daire alanı
//            return Math.PI * Radius * Radius;
//        }

//        public void Draw()
//        {
//            Console.WriteLine("Circle");
//        }
//    }

//    public class Rectangle : Ishape // dıkdortgen
//    { 
//        public double Width { get; set; } 
//        public double Height { get; set; } 

//        public Rectangle(double width, double height)
//        {
//            Width = width;
//            Height = height;
//        }

//        public double Area()
//        {
//            return Width * Height;
//        }

//        public void Draw()
//        {
//            Console.WriteLine("Regtangle");
//        }
//    }
//}
