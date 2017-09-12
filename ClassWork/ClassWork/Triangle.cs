using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Triangle
    {
        int a;
        int b;
        int c;

       public Triangle (int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void print_triangle()
        {
            Console.WriteLine(a + " " + b + " " + c);
        }

        public int perimeter()
        {
            return (a + b + c);
        }

        public double squertruangle()
        {
            double result;
            double p = perimeter() / 2;
            result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return (result);
        }

        public int A
        {
            get { return (a); }
            set { a = value; }
        }
        public int B
        {
            get { return (b); }
            set { b = value; }
        }
        public int C
        {
            get { return (c); }
            set { c = value; }
        }

        public int totriangle
        {
            get
            {
                if (a + b > c && a + c > b && c + b > a)
                    return (1);
                else
                    return (0);
            }
        }
    }
}
