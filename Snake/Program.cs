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

            //HotizontalLine line = new HotizontalLine(5,10,8,'+');// задаем положение точки
            //line.Drow();

            VerticalLine line1 = new VerticalLine(5, 70, 9, '&');// задаем положение точки
            line1.Drow();

            Console.ReadLine();
        }
    }
}
