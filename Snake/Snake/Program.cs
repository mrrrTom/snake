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
           // Walls new_walls = new Walls(25, 80);
            // new_walls.Draw();
            while (true)
            {
                snake.Move(Direction.Right);
                Thread.Sleep(200);
            }

            
        }
    }
}
