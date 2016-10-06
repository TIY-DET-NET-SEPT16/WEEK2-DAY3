using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesClass
{
    public abstract class Shape
    {
        //Shortcut to create 2 variables of the same type
        protected double x, y;

        public Shape()
        {

        }

        public Shape(double length, double width)
        {
            this.x = length;
            this.y = width;
        }

        public virtual double Area()
        {
            return x * y;
        }
    }

    public class Circle : Shape
    {
        public Circle(double r) : base(r, 0)
        {

        }

        public override double Area()
        {
            return x * x * Math.PI;
        }

    }

    public class Rectangle : Shape
    {
        public Rectangle(double wid, double len) : base(len, wid)
        {

        }
    }

    public class SpecialShape : Shape
    {
        public SpecialShape() : base()
        {

        }
    }

    public class Square : Shape
    {
        public Square(double side) : base(side, 0)
        {
        }

        public override double Area()
        {
            return x * x;
        }
    }

    enum days
    {
        Monday,
        Tuesday,
        Wednesday
    }

    enum students
    {
        Aston,
        Ike,
        Q,
        Ting,
        Chris,
        Jasmine,
        Justin
    }
}
