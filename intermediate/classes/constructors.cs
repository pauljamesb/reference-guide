// Constructors
// +++++++++++++++++++++++++++++++++++++++++++++

// Basic example
// "this" help to ensure the right assignments operator is used.

public class Customer
{
  public string Name;
  
  public Customer(string name)
  {
    this.Name = name;
  }
}

// With this values can be passed when the object is created.
var customer = new Customer("John");


// Example of Overloaded Constructors
// Notice, in this version below there is no default constructor anymore.
// But could have just by creating a blank constructor with no params.
// However this should only be used when it's really required to have intial values.
public class Customer 
{
  public int Id;
  public string Name;

  public Customer(int id)
  {
    this.Id = id;
  }

  public Customer(int id, string name)
  {
    this.Id = id;
    this.Name = name;
  }
}

// When a class has a list of objects List<Params>, the list should be initialised.
// Make sure not over this method below, not easy to follow.
// For example:
public class Customer 
{
  public int Id;
  public string Name;
  public List<Orders> Orders; // Note orders class doesn't exsist in this example.

  public Customer()
  {
    Orders = new List<Orders>();
  }
  
  public Customer(int id)
    : this() // Calls the first constructor so that the List can be inherited.
  {
    this.Id = id;
  }

  public Customer(int id, string name)
    : this(Id) // Calls the second, which has already called first with list and passes Id.
  {
    this.Name = name;
  }
}
