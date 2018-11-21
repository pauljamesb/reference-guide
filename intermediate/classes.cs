// Create an object from a string
// +++++++++++++++++++++++++++++++++++++++++++++++++
// Once object "Person" for example has already being created.

public Person Parse(string str)
{
  var person = new Person();
  person.Name = str;
  
  return person;
}
