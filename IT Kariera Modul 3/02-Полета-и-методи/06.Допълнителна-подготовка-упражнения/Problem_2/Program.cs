using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp289
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cmd = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rects = new Dictionary<string, Rectangle>();
            for (int i = 0; i < cmd[0];i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                if(!rects.ContainsKey(command[0]))
                {
                    rects.Add(command[0], new Rectangle(command[0], double.Parse(command[1]), double.Parse(command[2]), double.Parse(command[3]), double.Parse(command[4])));
                }
            }
            for(int i = 0; i < cmd[1]; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                Check(rects[command[0]], rects[command[1]]);
            }
        }

        private static void Check(Rectangle rectangle1, Rectangle rectangle2)
        {
            bool check = false;
            //rect1.Y2 >= rect2.Y1 || rect2.Y2 >= rect1.Y1
            //rect1.X2 >= rect2.X1 || rect2.X2 >= rect1.X1
            if (rectangle1.Y11 >= rectangle2.y || rectangle1.y <= rectangle2.Y11)
            {
                check = true;
            }
            if (rectangle1.X11 >= rectangle2.x || rectangle1.x <= rectangle2.X11)
            {
                check = true;
            }
            Console.WriteLine(check.ToString().ToLower());
        }
    }
}
