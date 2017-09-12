using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Point
    {
        int x;
        int y;
        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(int a, int b)
        {
            x = a;
            y = b;
        }

        public void PrintCoord()
        {
            Console.WriteLine("x = " + x + " y = " + y);
        }

        public double DistanceToPoint()
        {
            double result;
            result = Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2)));
            return (result);
        }

        public int X
        {
            get
            {
                return (x);
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return (y);
            }
            set
            {
                 y= value;
            }
        }
    }
}
