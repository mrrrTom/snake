using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake
    {
        List<Point> Zmeya;

        Direction direction;
        public Snake()
        {
            direction = Direction.Right;
            Zmeya = new List<Point>();
            Zmeya.Add(new Point(30, 10, '0'));
            Zmeya.Add(new Point(29, 10, '='));
            Zmeya.Add(new Point(28, 10, '='));
            Zmeya.Add(new Point(27, 10, '='));
            foreach(Point p in Zmeya)
            {
                p.Draw();
            }

        }

        public void Move(Direction temp_direction)
        {
            this.direction = temp_direction;

            switch (direction)
            {
                case Direction.Right:
                    Zmeya[Zmeya.Count-1].Clear();
                    foreach (Point p in Zmeya)
                    {
                        p.x = p.x+1;
                        p.Draw();
                    }
                    
                    break;

            }
        }
    }
}
