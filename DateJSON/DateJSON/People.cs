using System;

namespace DateJSON
{
    public class People
    {
        public People(string _name, DateTime _dateOfBirth)
        {
            this.Name = _name;
            this.DateOfBirth = _dateOfBirth;
        }

        public string Name { get; private set; }
        public DateTime DateOfBirth { get; private set; }
    }

}
