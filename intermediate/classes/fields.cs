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
Public class Customer
{
    readonly List<Order> Orders = new List<Order>();
}
