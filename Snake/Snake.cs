using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure 
    {
        public Snake(Point tail,int length,Direction direction)
        {
            plist = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);// создаются точки, являющиися точной копией хвостовой точки
                p.Move(i, direction); // сдвигается на i позиций по направлению дирекции и добавить точку в список
                plist.Add(p);
            } 

        }
    }
}
