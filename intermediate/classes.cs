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
var p = person.Parse("John");


// But a better way would be to use a static class.
// Same example above but with static applied.

public static Person Parse(string str)
{
  var person = new Person();
  person.Name = str;
  
  return person;
}

var p = Person.Parse("John");
