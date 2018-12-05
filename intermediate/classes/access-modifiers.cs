// Access Modifiers
// Used for security.

// Public
// Private
// Protected
// Internal
// Protected Internal


public class Customer 
{
  private string Name;
}

// This would not complie
var john = new Customer();
john.Name;


// Three major concepts in OOP
// Encapsulation / Info hiding
// This helps to hide the detail from other classes of methods for example.
// Getter/Setter for example.

// Inheritance
// Polymorphism

// Encapsulation continued
// Example of full get and set, not shorthand

// This happens behind the scenes of get set

// Side note, very important, look how the private string is camel case and carries an underscore.

public class Person 
{
    private string _name;
  
    public void SetName(string name)
    {
      if (!String.IsNullOrEmpty(name))
        this._name = name;
    }
  
    public string GetName()
    {
        return _name;
    }
}



