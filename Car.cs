using System;

namespace oop
{
    public class Car : Vehicle
    {
        /*inheriting the vehicle class creates an instance of this class, 
        inherted classes use the paraeterless construstors by default.. to change this, use the base keyword
        */       
        public Car(string registrationNumber) :base(registrationNumber)
        {
            Console.WriteLine("intializing a car. {0}", registrationNumber);
        }
    }
}




