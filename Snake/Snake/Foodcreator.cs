using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
   public class Foodcreator

    {
        public Point Korm;
        public Foodcreator(int visota, int shirina, char symb)
        {
            
            Random rnd1 = new Random();
            Random rnd2 = new Random();

            Korm = new Point(rnd1.Next(1, shirina - 1), rnd2.Next(1, visota - 1), '$');
            Korm.Draw();
        }
    }
}
