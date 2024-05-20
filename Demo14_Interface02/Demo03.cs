using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo14_Interface02.Demo03
{
    /// <summary>
    ///     Class Hierarchy Demo
    /// </summary>
    internal class Demo
    {
        public static void RunThis()
        {
            // Quadrilateral objQuadrilateral = new Quadrilateral();
            Rectangle objRect = new Rectangle(10, 20);
            Console.WriteLine("Area of Rectangle = {0}", objRect.Area());
            Console.WriteLine("Length = {0}, Breadth = {1}", objRect.Length, objRect.Breadth);

            Square objSquare = new Square(5);
            Console.WriteLine("Area of Square = {0}", objSquare.Area());
        }
    }

    public abstract class Shape
    {
        public abstract decimal Area();
    }

    abstract public class Quadrilateral : Shape
    {
        protected int Side1 { get; private set; }
        protected int Side2 { get; private set; }
        protected int Side3 { get; private set; }
        protected int Side4 { get; private set; }

        protected Quadrilateral(int side1, int side2, int side3, int side4)
        {
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
            this.Side4 = side4;
        }

        public override decimal Area()
        {
            decimal retVal = 0.0M; // (decimal)0.0;
            retVal = this.Side1 * this.Side2;
            return retVal;
        }
    }

    public class Rectangle : Quadrilateral
    {
        public int Length
        {
            get
            {
                return base.Side1;
            }
        }

        public int Breadth
        {
            get { return base.Side2; }
        }

        public Rectangle(int length, int breadth) 
            : base(length, breadth, length, breadth)
        {
        }
    }

    public class Square : Quadrilateral
    {
        public Square(int side)
            : base(side, side, side, side)
        {
        }
    }

    public class Triangle : Shape
    {
        public override decimal Area()
        {
            decimal retVal = 0.0M; // (decimal)0.0;
            return retVal;
        }
    }
}
