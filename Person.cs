using System;

namespace oop
{
    public class Person
    {
        public string Name;
       
        //using properties to create a get and set methods
        //public DateTime Birthdate { get; set; } //get and set can be called from another class since it is public

        //make the set method private so the birthdate can only be set once.. then use a construtor to set it below
        public DateTime Birthdate { get; private set; } 

        //creating a property with a set method
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }

        //the constructor to privately set birthdate
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        //public static Person Parse(string str)
        //{
        //    var person = new Person();
        //    person.Name = str;

        //    return person;
        //}
    }
}

