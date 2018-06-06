using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Point> hor_wall_top;
        List<Point> hor_wall_bottom;
        List<Point> ver_wall_left;
        List<Point> ver_wall_right;

        public Walls (int visota, int shirina)
        {
            hor_wall_top = new List<Point>() ;
            hor_wall_bottom = new List<Point>();
            ver_wall_left = new List<Point>();
            ver_wall_right = new List<Point>();

            for(int i=0;i<shirina-1;i++ )
            {
                Point p_i = new Point(i,0,'+') ;
                hor_wall_top.Add(p_i);
                Point pt_i = new Point(i, visota-1, '+');
                hor_wall_bottom.Add(pt_i);

            }
            for(int i = 1; i < visota-1; i++)
            {
                Point p_i = new Point(0, i, '+');
                ver_wall_left.Add(p_i);
                Point pt_i = new Point(shirina-1, i, '+');
                ver_wall_right.Add(pt_i);
            }
        }

        
        public void Draw()
        {
            foreach(Point p in hor_wall_top)
            {
                p.Draw();
            }
            foreach(Point p in hor_wall_bottom)
            {
                p.Draw();
            }
            foreach(Point p in ver_wall_left)
            {
                p.Draw();
            }
            foreach(Point p in ver_wall_right)
            {
                p.Draw();
            }
        }
    }
}
