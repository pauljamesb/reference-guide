// Create an object from a string
// +++++++++++++++++++++++++++++++++++++++++++++++++
// Once object "Person" for example has already being created.
// Also have to create new "Person" first to use.

public Person Parse(string str)
{
  var person = new Person();
  person.Name = str;
  
  return person;
}

var person = new Person();
person.Parse("John");
