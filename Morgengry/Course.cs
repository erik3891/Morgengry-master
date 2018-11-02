using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Course
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        private int _durationInMinutes;
        public int DurationInMinutes
        {
            get
            {
                return _durationInMinutes;
            }
            set
            {
                _durationInMinutes = value;
            }
        }
        public Course(string name, int durationInMinutes)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
        }
        public Course(string name) : this(name, 0)
        {
        }
        public override string ToString()
        {
            return "Name: " + Name + ", Duration in Minutes: " + DurationInMinutes;
        }
    }
}
