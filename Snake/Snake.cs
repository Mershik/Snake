using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure 
    {
        public Direction direction;

        public Snake(Point tail,int length,Direction _direction)
        {
            direction = _direction;
            plist = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);// создаются точки, являющиися точной копией хвостовой точки
                p.Move(i, direction); // сдвигается на i позиций по направлению дирекции и добавить точку в список
                plist.Add(p);
            } 

        }

        internal void Move()
        {
            Point tail = plist.First();
            plist.Remove(tail);
            Point head = GetNextPoint();
            plist.Add(head);

            tail.Clear(); // убирается последняя точка
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = plist.Last();
            Point nextPoint = new Point(head);  
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
        }
    }
}
