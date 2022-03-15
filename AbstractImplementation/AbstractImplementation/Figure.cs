using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractImplementation
{
    public abstract class Figure
    {
        public double Width, Height, Radius;
        public const float Pi = 3.14f;
        public abstract double GetArea(); // declaration

        
    }
    // we use reusability
    public class Rectangle : Figure // heritange from figure, use the same atributes
    {
        public Rectangle(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        // implementation of abstract method
        public override double GetArea()
        {
            return Width * Height;
        }

    }
    public class Circle : Figure
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        // implementation of abstract method
        public override double GetArea()
        {
            return Pi* Radius* Radius;
        }
    }
    public class Cone : Figure
    {

        public Cone(double Radius, double Height)
        {
            this.Radius = Radius;
            this.Height = Height;
                
        }
        public override double GetArea()
        {
            return Pi * Radius;  // logic for the cone
        }
    }
    
    class TestFigures
    {
        static void Main()
        {
            Rectangle r = new Rectangle(4, 4);
            Circle c = new Circle(34);
            Cone C = new Cone(34.98, 12.98);

            Console.WriteLine("Area of rectangle: " + r.GetArea());
            Console.WriteLine("Area of circle: " + c.GetArea());
            Console.WriteLine("Area of Cone: " + C.GetArea());
        }
    }


}
