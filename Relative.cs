using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Relative : IComparable
    {
        //properties
        public string Name { get; set; }
        public string Relationship { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }

        //constructor
        public Relative(string name, string relationship, int month, int day, int year)
        {
            Name = name;
            Relationship = relationship;
            Month = month;
            Day = day;
            Year = year;
        }

        //Override ToString()
        public override string ToString()
        {
            return String.Format("{0}, born {1}/{2}/{3} is your {4}.", this.Name, this.Month, this.Day, this.Year, this.Relationship);
        }

        //CompareTo() - set what each relative should be compared with
        int IComparable.CompareTo(object obj)
        {
            Relative temp = (Relative)obj;

            return String.Compare(this.Name, temp.Name);
        }
    }
}
