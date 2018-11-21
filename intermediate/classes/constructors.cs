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
