using System;

namespace oop
{
    partial class MainClass
    {
        static void Main(String[] args)
        {
            //var person = new Person();
            //person.Name = "Godwin Otokina";
            //person.Introduce("Titi");

            //var person = Person.Parse("Johhn");

            //person.Introduce("Olu");

            //var customer = new Customer(23, "Godwin Otokina");

            //Console.WriteLine(customer.Id);

            //var calculator = new Calculator();
            //Console.WriteLine(calculator.Add(1, 2, 8));

            //var shop = new Shop(1);
            //shop.Orders.Add(new Order());
            //shop.Orders.Add(new Order());

            //Console.WriteLine(shop.Orders.Count);

            //var birthday = new Birthday();
            //birthday.SetBirthdate(new DateTime(1994, 08, 22));
            //Console.WriteLine(birthday.GetBirthdate());

            // the next two lines can only be done if the get and set method of Brithdate in the Person class are public
            //var person = new Person();
            //person.Birthdate = new DateTime(1994, 8, 22); 

            //if the set method is private, use the construtor to set it
            //var person = new Person(new DateTime(1994, 8, 22));
            //Console.WriteLine(person.Age);

            //var cookie = new HtttpCookie();
            //cookie["name"] = "Godwin Otokina";
            //Console.WriteLine(cookie["name"]);

            //composition example
            var logger = new Logger();
            var composition = new Composition(logger);
            composition.compose();
        }
    }
}




