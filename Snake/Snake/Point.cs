﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
   public class Point
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

            
            
                Console.SetCursorPosition(x, y);
                Console.Write(symb);
            
         
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
