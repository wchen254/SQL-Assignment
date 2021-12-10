using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY2
{
    public class BallRepo : IBalls<Ball>
    {
        List<Ball> balls = new List<Ball>();

        public int Insert(Ball obj)
        {
            balls.Add(obj);
            return 1;
        }

        public int Throw(int id)
        {
            for (int i = 0; i < balls.Count; i++)
            {
                if (balls[i].Id == id && balls[i].Size != 0)
                {
                    balls[i].timesThrown++;
                    return 1;
                }
            }
            return 0;
 
        }

        public int Pop(int id)
        {
            for (int i = 0; i < balls.Count; i++)
            {
                if (balls[i].Id == id)
                {
                    balls[i].Size = 0;
                    return 1;
                }
            }
            return 0;
        }
    }
}
