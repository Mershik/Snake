﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        { 

            Walls walls = new Walls(1, 80);
            walls.Draw();

            //Отрисовка рамки
            //HotizontalLine line = new HotizontalLine(1,60,0,'-');
            //line.Drow();
            //HotizontalLine line1 = new HotizontalLine(1, 60, 25, '-');
            //line1.Drow();

            //VerticalLine line2 = new VerticalLine(1, 24, 1, '|');
            //line2.Drow();
            //VerticalLine line3 = new VerticalLine(1, 24, 60, '|');
            //line3.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();

            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);



                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

            }
            
        }
    }
}
