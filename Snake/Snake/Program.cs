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
            eat eat = new eat();

            Direction direction = Direction.Right;
             Walls new_walls = new Walls(25, 80);
             new_walls.Draw();

            Foodcreator fc = new Foodcreator(25, 80,'$');

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
                try
                {
                    
                    snake.Move(direction, eat);
                    if (snake.Zmeya[0].x == fc.Korm.x && snake.Zmeya[0].y == fc.Korm.y)
                    {
                        eat = eat.yes;
                        fc = new Foodcreator(25, 80, '$');
                    }
                    else { eat = eat.no; }

                }
                catch (System.ArgumentOutOfRangeException)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(25, 8);
                    Console.WriteLine("============================");
                    Console.SetCursorPosition(26, 9);
                    Console.WriteLine("И Г Р А    О К О Н Ч Е Н А");
                    Console.SetCursorPosition(30, 10);
                    Console.WriteLine("Автор: DANISSIMO");
                    Console.SetCursorPosition(29, 11);
                    Console.WriteLine("KAK ZGE YA EBASHU!!!");
                    Console.SetCursorPosition(25, 12);
                    Console.WriteLine("============================");
                    while (true)
                    {
                        if (Console.KeyAvailable)
                        {
                            ConsoleKeyInfo Key = Console.ReadKey();
                            if (Key.Key == ConsoleKey.LeftArrow)
                            {
                                direction = Direction.Left;
                            }
                            if (Key.Key == ConsoleKey.UpArrow)
                            {
                                direction = Direction.Up;
                            }
                            if (Key.Key == ConsoleKey.DownArrow)
                            {
                                direction = Direction.Down;
                            }
                            if (Key.Key == ConsoleKey.RightArrow)
                            {
                                direction = Direction.Right;
                            }

                        }
                        snake.Move_(direction);
                        Thread.Sleep(200);
                    }
                }

                Thread.Sleep(200);
            }

            
        }
    }
}
