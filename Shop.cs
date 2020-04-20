using System.Collections.Generic;

namespace oop
{
    public class Shop
    {
        public int Id;
        public string Name;
        public string Location;
        //intialize a list here
        public List<Order> Orders = new List<Order>();

        public Shop(int id)
        {
            this.Id = id;
        }

        //this.id(id) calls the first constructor that sets id field
        public Shop(int id, string name, string location)
            : this(id)
        {
            this.Name = name;
            this.Location = location;
        }

        public void Promote()
        {
            Orders = new List<Order>();
        }
    }

}


































