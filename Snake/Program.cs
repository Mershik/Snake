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

            List<int> numlist = new List<int>(); //Создали переменную numlist, которая является объектом класса List, которая будет хранить список целчисленных переменных
            numlist.Add(0);
            numlist.Add(1);
            numlist.Add(2); // список содержит 3 цельночисленных переменных

            int x = numlist[0];
            int y = numlist[1];
            int z = numlist[2];

            foreach (int i in numlist)
            {
                Console.WriteLine(i);
            }

            numlist.RemoveAt(0); // для того, чтобы удалить элемент

            List<Point> plist = new List<Point>(); // список, который содержит несколько точек и добавлены 2 переменные р1 и р2
            plist.Add(p1);
            plist.Add(p2);
            // инкапсуляция - это способ скрывать детали своей реализации
            Console.ReadLine();
        }
    }
}
