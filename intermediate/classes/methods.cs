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
// Overloading
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
    
    // Or you could do:
    public void Move(Point newLocation)
    {
        if (newLocation == null)
            throw new ArgumentNullException("newLocation");
        
        Move(newLocation.X, newLocation.Y);
    }    
}

// 




// The main method code here
public class Calculator
{
    public int Add(params int[] numbers)
    {
        var sum = 0;
        foreach(var number in numbers)
        {
            sum += number;
        }
        
        return sum;
    }
}


// Needs a class like Program

public class Program
{
    
        // Main here
        var calculatro = new Calculator();
        Console.WriteLine(calculator.Add(1,2));
        Console.WriteLine(calculator.Add(1,2,3));
    
        static void UsePoints()
        {
            try
            {  
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine(point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine(point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("Error occured");
            }
        }

}




