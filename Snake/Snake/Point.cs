using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char symb;

        public Point(int x, int y, char symb)
        {
            this.x = x;
            this.y = y;
            this.symb = symb;
        }

        public void Draw()
        {
            try
            {
                Console.SetCursorPosition(x, y);
                Console.Write(symb);
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
            }
        }

        public void Clear()
        {
            Point P = new Point(this.x, this.y, ' ');
            P.Draw();
        }

        public void Priravnyat(Point P)
        {
            this.x = P.x;
            this.y = P.y;
            
        }
    }
}
