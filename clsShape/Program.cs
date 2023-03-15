using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsShape
{
    internal class Program
    {
        static void Main(string[] args)
        {

            clnShape shape1 = new clnShape();
            shape1.Name = "shape1";
            shape1.Sides = 0;
            Console.WriteLine(shape1);

            clnShape shape2 = new clnShape();
            shape2.Name = "shape2";
            shape2.Sides = 0;
            Console.WriteLine(shape2);

            clnSquare shape3 = new clnSquare("Square",4,4);
            Console.WriteLine(shape3);

            clnRectangle shape4 = new clnRectangle("Rectangle",4,3,5);
            Console.WriteLine(shape4);
        }
    }
}
