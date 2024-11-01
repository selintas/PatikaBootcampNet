using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterfaceV
{
    // abstarct yontemı ile
    public abstract class Shape
    {
        public abstract void Draw();

        public virtual double Area()
        { return 0; }
    }

    public class Circle : Shape
    {
        public double Radius {  get; set; }

        public Circle(double radius)  
        {
            Radius = radius;
        }
        public override void Draw()
        {
            Console.WriteLine("circle");
        } 
        public override double Area()  
        {  
            //pi*r*r
            return Math.PI * Radius * Radius;
        }
    }
}