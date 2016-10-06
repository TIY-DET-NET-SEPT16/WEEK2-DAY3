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
            //Circle c = new Circle(5);
            //Circle c2 = new Circle(2);
            //double areaOfCircle = c.Area();

            //Rectangle rect = new Rectangle(10, 5);
            //rect.Area();

            //SpecialShape ss = new ShapesClass.SpecialShape();
            //double placeToStoreAnwser = ss.Area();
            //double example = 5;

            //Console.WriteLine("The area of my special shape is");
            //Console.WriteLine(ss.Area());

            //Square square2 = new Square(5);
            //double valueOfAreaCalculation = square2.Area();

            //if (days.Monday == 0)
            //{
            //    Console.WriteLine("It's Monday");

            //    Console.WriteLine("Day is " + days.Monday);
            //    Console.WriteLine("Another way to say it " + (int)days.Monday);
            //}
            //days myDay = 0;
            //days newDay = days.Tuesday;

            //switch (myDay)
            //{
            //    case days.Monday:
            //        {
            //            Console.WriteLine("It's Monday");
            //            break;
            //        }
            //    case days.Tuesday:
            //        {
            //            Console.WriteLine("Now it's Tuesday");
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("It must be Wednesday");
            //            break;
            //        }
            //}

            //for(int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(string.Format("{0} is a student in the list", ));
            //}

            Square[] mySquareArray = new Square[2];
            mySquareArray[0] = new Square(4);

            List<Square> mySquareList = new List<Square>();
            mySquareList.Add(new Square(4));

            for(int i = 0; i < 5; i++)
            {
                mySquareList.Add(new Square(i + 1));
            }
            int len = mySquareArray.Length;

            for(int i = 0; i < mySquareList.Count; i++)
            {
                Console.WriteLine(string.Format("The area of this square is {0}",
                    mySquareList[i].Area()));
            }
            
            Console.ReadLine();
        }
    }
}
