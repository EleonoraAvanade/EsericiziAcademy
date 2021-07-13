using System;
using System.Collections.Generic;
using Week1_AC_1_2.Classi;

namespace Week1_AC_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> fig = new List<Shape>();
            Helper h = new Helper();
            bool check=true;
            while (check)
            {
                check = Helper.Menu(fig);
            }
        }
    }
}
