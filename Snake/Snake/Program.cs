using System;
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
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            Snake snake = new Snake();
            
            Direction direction = Direction.Right;
           // Walls new_walls = new Walls(25, 80);
            // new_walls.Draw();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                  ConsoleKeyInfo Key =  Console.ReadKey();
                    if (Key.Key == ConsoleKey.LeftArrow)
                    {
                        direction = Direction.Left;
                    }
                    if(Key.Key == ConsoleKey.UpArrow)
                    {
                        direction = Direction.Up;
                    }
                    if (Key.Key == ConsoleKey.DownArrow)
                    {
                        direction = Direction.Down;
                    }
                    if(Key.Key == ConsoleKey.RightArrow)
                    {
                        direction = Direction.Right;
                    }
                }
                snake.Move(direction);
                
                Thread.Sleep(200);
            }

            
        }
    }
}
