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
            Zmeya.Add(new Point(30, 10, '*'));
            Zmeya.Add(new Point(29, 10, '@'));
            Zmeya.Add(new Point(28, 10, '@'));
            Zmeya.Add(new Point(27, 10, '@'));
            foreach(Point p in Zmeya)
            {
                p.Draw();
            }

        }
        
        public void Move(Direction temp_direction)
        {
            this.direction = temp_direction;
            for (int i = Zmeya.Count - 1; i > 0; i--)
            {
                if ((Zmeya[i].x == Zmeya[0].x)&&(Zmeya[i].y==Zmeya[0].y))
                {
                    Point p = new Point(100, 100, '!');
                    p.Draw();
                }
            }
                switch (direction)
            {
                case Direction.Right:

                    Zmeya[Zmeya.Count-1].Clear();                   
                    
                    for (int i = Zmeya.Count-1; i > 0; i--)
                    {
                        Zmeya[i].Priravnyat(Zmeya[i - 1]);
                        Zmeya[i].Draw();                       
                    }

                    Zmeya[0].x = Zmeya[0].x + 1;
                    Zmeya[0].Draw();
                    
                    break;

                case Direction.Left:
                    Zmeya[Zmeya.Count - 1].Clear();

                    for (int i = Zmeya.Count - 1; i > 0; i--)
                    {
                        Zmeya[i].Priravnyat(Zmeya[i - 1]);
                        Zmeya[i].Draw();
                    }

                    Zmeya[0].x = Zmeya[0].x - 1;
                    Zmeya[0].Draw();

                    break;
                case Direction.Up:
                    Zmeya[Zmeya.Count - 1].Clear();

                    for (int i = Zmeya.Count - 1; i > 0; i--)
                    {
                        Zmeya[i].Priravnyat(Zmeya[i - 1]);
                        Zmeya[i].Draw();
                    }

                    Zmeya[0].y = Zmeya[0].y - 1;
                    Zmeya[0].Draw();

                    break;
                case Direction.Down:
                    Zmeya[Zmeya.Count - 1].Clear();

                    for (int i = Zmeya.Count - 1; i > 0; i--)
                    {
                        Zmeya[i].Priravnyat(Zmeya[i - 1]);
                        Zmeya[i].Draw();
                    }

                    Zmeya[0].y = Zmeya[0].y + 1;
                    Zmeya[0].Draw();
                    break;

            }
        }
    }
}
