using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY2
{
    public class Ball
    {
        public int Id { get; set; }
        public int Size { get; set; }
        public Color Color { get; set; }

        public int timesThrown = 0;
        public void Pop(Ball ball)
        {
            ball.Size = 0;
        }

        public void Throw(Ball ball)
        {
            if (ball.Size != 0)
            {
                ball.timesThrown++;
            }
        }

        public int TimeBeenThrown(Ball ball)
        {
            return ball.timesThrown;
        }
    }
}
