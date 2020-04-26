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
            
            //Отрисовка рамки
            HotizontalLine line = new HotizontalLine(1,30,0,'+');
            line.Drow();
            HotizontalLine line1 = new HotizontalLine(1, 30, 10, '+');
            line1.Drow();

            VerticalLine line2 = new VerticalLine(1, 9, 1, '+');
            line2.Drow();
            VerticalLine line3 = new VerticalLine(1, 9, 30, '+');
            line3.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            Console.ReadLine();
        }
    }
}
