using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY2
{
    public class Color
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public int alpha = 255;

        public void grayscale()
        {
            int grayscale = (Red + Green + Blue) / 3;
            Console.WriteLine($"The grayscale value for the color [{Red},{Green},{Blue}] is {grayscale}");
        }
        public Color(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
    }
}
