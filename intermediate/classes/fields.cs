// Initializing a class

// One

public class Customer
{

    List<Order> Orders;
    
    public Customer()
    {
        Orders = new List<Order>();
    }

}

// Two

public class Customer
{
    List<Order> Orders = new List<Order>();
}




// Read-only Fields
// This ensures there would only be one list where orders would be kept.
// If it got initialized else where the data would not be lost.
Public class Customer
{
    readonly List<Order> Orders = new List<Order>();
}


// Working example:
using System;
using System.Collections.Generic;

namespace Fields
{
    
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            //..
            Orders = new List<Order>();
        }
    }


    public class Order 
    {}
    
    class MainClass
    {
        public static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            // Pretend bug, initializes the list again
            // The readonly modifier prevents this
            // An error will show in Promote();
            customer.Promote();

            Console.WriteLine(customer.Orders.Count);
        }
    }
}

