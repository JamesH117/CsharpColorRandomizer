using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorSwapper.Properties
{
    class RandomizeColor
    {
        int a_value = 0;
        int r_value = 0;
        int g_value = 0;
        int b_value = 0;

        public int[] NewColor()
        {
            Random rnd = new Random();
            a_value = rnd.Next(0, 255);
            r_value = rnd.Next(0, 255);
            g_value = rnd.Next(0, 255);
            b_value = rnd.Next(0, 255);
            int[] colors = new int[] { a_value, r_value, g_value, b_value };

            return colors;

        }
    }
}
