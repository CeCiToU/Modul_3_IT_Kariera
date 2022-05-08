using System;

namespace ConsoleApp282
{
    internal class DateModifier
    {
        private DateTime firstDate;
        private DateTime secondDate;
        public DateTime FirstDate
        {
            get { return firstDate; }
            set { firstDate = value; }
        }
        public DateTime SecondDate
        {
            get { return secondDate; }
            set { secondDate = value; }
        }

        internal void Substract()
        {
            if(FirstDate.CompareTo(SecondDate) > 0)
            {
                Console.WriteLine((FirstDate - SecondDate).ToString("dd"));
            }
            else
            {
                Console.WriteLine((SecondDate - FirstDate).ToString("dd"));
            }
        }
    }
}