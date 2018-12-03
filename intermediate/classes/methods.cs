// METHODS
// Params overloading example

// This shows an array of ints.
public class Calculator 
{
    public int Add(params int[] numbers)
    {
    }
}

var results = Calculator.Add(1,2,3,4,5,6);
