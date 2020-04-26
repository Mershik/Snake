using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');  
            p1.Draw();

            Point p2 = new Point(4,5,'#');
            p2.Draw();

            HotizontalLine line = new HotizontalLine(1,30,0,'+');
            line.Drow();
            HotizontalLine line1 = new HotizontalLine(1, 30, 10, '+');
            line1.Drow();

            VerticalLine line2 = new VerticalLine(1, 9, 1, '+');
            line2.Drow();
            VerticalLine line3 = new VerticalLine(1, 9, 30, '+');
            line3.Drow();

            Console.ReadLine();
        }
    }
}
