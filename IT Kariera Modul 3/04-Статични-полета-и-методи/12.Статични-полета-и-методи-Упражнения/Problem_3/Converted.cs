using System;

namespace ConsoleApp291
{
    internal class Converted
    {
        private double num;

        public double Num
        {
            get { return num; }
            set
            {
                num = Math.Sqrt(value);
            }
        }

        public override string ToString()
        {
            return num + "";
        }
    }
}