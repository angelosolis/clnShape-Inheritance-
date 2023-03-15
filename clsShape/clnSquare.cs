using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace clsShape
{
    internal class clnSquare : clnShape
    {
        private double side2;
        public clnSquare()
        {

        }
        public clnSquare(string name, int sides, double side2) 
        {
            base.Name = name;
            base.Sides = sides;
            this.Side2 = side2;

        }

        public double Side2 { get => side2; set => side2 = value; }
        public override double ComputeArea()
        {
            return side2 * side2;
        }

        public override double ComputePerimeter()
        {
            return 4 * side2;
        }

        public override string ToString()
        {
            return "\nName: " + this.Name +
                   "\nSides: " + this.Sides +
                   "\nArea: " + this.ComputeArea() +
                   "\nPerimeter: " + this.ComputePerimeter(); 
        }
    }
}
