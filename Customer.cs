using System;
namespace oop
{
    public class Customer
    {
        public int Id;
        public string Name;
        public string Dept;

        //create a constructor
        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        //overload constructor
        public Customer(int id, string name, string dept)
        {
            this.Id = id;
            this.Name = name;
            this.Dept = dept;
        }
    }
}
