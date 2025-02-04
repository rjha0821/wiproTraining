using System;

// Define delegate type
// Complete Step 1:............
public delegate int Operation(int x, int y);
class Program
{
    // Implement delegate methods
    // Complete Step 2:............
    public static int Add(int x, int y) => x + y;

    public static int Subtract(int x, int y) => x - y;

    public static int Multiply(int x, int y) => x * y;

    public static int Divide(int x, int y) => y != 0 ? x / y : throw new DivideByZeroException();

    // Implement callback mechanism
    // Complete Step 3:............
    public static int PerformOperation(int x, int y, Operation operation) => operation(x, y);
    

    static void Main(string[] args)
    {
        try{
            Console.WriteLine("Enter first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter operation (add, subtract, multiply, divide):");
        string operation = Console.ReadLine().ToLower();

        // Step 5: Output handling
        Operation selectedOperation = operation switch
        {
            "add" => Add,
            "subtract" => Subtract,
            "multiply" => Multiply,
            "divide" => Divide,
            _ => throw new InvalidOperationException("Invalid operation")
        };
        int res = PerformOperation(num1, num2, selectedOperation);
        Console.WriteLine($"Result: {res}");
        }
        catch(Exception ex){
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

Program.Main(null);