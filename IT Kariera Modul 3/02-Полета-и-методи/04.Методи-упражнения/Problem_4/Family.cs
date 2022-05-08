using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp281
{
    internal class Family
    {
        private List<Person> families = new List<Person>();

        public List<Person> Families
        {
            get { return families; }
            set { families = value; }
        }


        internal void AddFamily(Person person)
        {
            Families.Add(person);
        }

        public Person GetOldestMember()
        {
            Families = Families.OrderByDescending(x => x.Age).Take(1).ToList();
            Person theOldest = Families[0];
            return theOldest;
        }
    }
}