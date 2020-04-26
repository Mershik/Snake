using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HotizontalLine
    {
        List<Point> plist; //создается набор точек
         
        public HotizontalLine(int xLeft, int xReight, int y, char sym) //констуктор класа (метод, который будет вызываться при создании линии
        {
            plist = new List<Point>(); // создаем пустой список

            for (int x = xLeft; x <= xReight; x++) //каждая итерация Х будет получать значение с лево на право
            {
                Point p = new Point(x, y, sym);
                plist.Add(p); // добавляем в список точек
            }
 
        }

        public void Drow() // метод для фывода на экран точек
        {
            foreach (Point i in plist) //пробегаем по всем точкам
            {
                i.Draw();
            }
        }
    }
}
