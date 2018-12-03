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


// Methods cont..
public class Point
{
    public int X;
    public int Y;
    
    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }
    
    public void Move(int x, int y)
    {
        this.X = x;
        this.y = Y;
    }
    
    public void Move(Point newLocation)
    {
        this.X = newLocation.X;
        this.Y = newLocation.Y;
    }
    
}




// The main here


