using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(5);
            Circle c2 = new Circle(2);
            double areaOfCircle = c.Area();
            
            Rectangle rect = new Rectangle(10, 5);
            rect.Area();

            SpecialShape ss = new ShapesClass.SpecialShape();
            double placeToStoreAnwser = ss.Area();
            double example = 5;

            Console.WriteLine("The area of my special shape is");
            Console.WriteLine(ss.Area());

            Square square2 = new Square(5);
            double valueOfAreaCalculation = square2.Area();
        }
    }
}
