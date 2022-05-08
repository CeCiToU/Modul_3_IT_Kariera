using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp283
{
    internal class Family
    {
        private List<Person> semeistwo = new List<Person>();
        public List<Person> Familly
        {
            get { return semeistwo; }
            set { semeistwo = value; }
        }

        public void AddMember(Person member)
        {
            Familly.Add(member);
        }
        internal List<string> TakeGreaterThan30()
        {
            Familly = Familly.OrderBy(x => x.Name).ToList();
            List<string> oldest =new List<string>();
            for (int i = 0; i < Familly.Count; i++)
            {
                int currentAge = Familly[i].Age;
                if(currentAge > 30)
                {
                    oldest.Add($"{Familly[i].Name} - {Familly[i].Age}");
                }
            }
            return oldest;
        }
    }
}