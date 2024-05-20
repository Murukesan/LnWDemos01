using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo14_Interface02.Demo04
{
    public class Demo
    {
        public static void RunThis()
        {
            IRectangle objRect = new Demo04.Quadrilateral(10, 20);
            Console.WriteLine("Area of Rectangle = {0}", objRect.Area());
            ISquare objSquare = new Quadrilateral(5);
            Console.WriteLine("Area of Square = {0}", objSquare.Area());

        }
    }

    interface IShape
    {
        decimal Area();
    }

    interface IRectangle 
    {
        decimal Area(); 
    }

    interface ISquare
    {
        decimal Area();
    }

    public class  Quadrilateral : IShape, IRectangle, ISquare 
    {
        private int side1, side2, side3, side4;

        /// <summary>
        ///     Instantiates a Rectangle
        /// </summary>
        /// <param name="length">length of the rectangle</param>
        /// <param name="breadth">breadth of the rectangle</param>
        public Quadrilateral(int length, int breadth)
        {
            this.side1 = this.side3 = length;
            this.side2 = this.side4 = breadth;
        }

        public Quadrilateral(int side)
        {
            this.side1 = this.side2 = this.side3 = this.side4 = side;
        }

        decimal IShape.Area()
        {
            throw new NotImplementedException();
        }

        decimal IRectangle.Area()
        {
            return this.side1 * this.side2;
        }

        decimal ISquare.Area()
        {
            return this.side1 * this.side1;
        }
    }
}
