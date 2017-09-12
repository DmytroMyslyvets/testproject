using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Rectangle
    {
        int a, b;
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void print_rect()
        {
            Console.WriteLine(a + " " + b);
        }
        public int perimeter()
        {
            return (a + b);
        }

        public int sqr_rect()
        {
            return (a * b);
        }

        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public int B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }

        public int chek
        {
            get
            {
                if (a == b)
                    return (1);
                else
                    return (0);
            }
        }
    }
}
