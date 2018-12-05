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
Public class Customer
{
    readonly List<Order> Orders = new List<Order>();
}
