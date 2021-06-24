using System;

namespace MyFirstApp
{
    public class Person
    {
        public string Name;
        public int Weight;
        public DateTime Birthdate {get; private set;}
        
        public Person(string name, DateTime birthday)
        {
            this.Name = name;
            this.Birthdate = birthday;
        }
        
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}