using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> plist;

        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            plist = new List<Point>();

            for (int i = yUp; i <= yDown; i++)
            {
                Point p = new Point(x, i, sym);
                plist.Add(p);
            }
        }

        public void Drow() 
        {
            foreach (Point i in plist) 
            {
                i.DrawVertical();
            }
        }
    }
}
