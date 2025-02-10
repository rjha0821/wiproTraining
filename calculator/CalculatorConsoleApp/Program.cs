using System;
using CalculatorLibrary;  // Add reference to your library

class Program
{
    static void Main(string[] args)
    {
        var calculator = new Calculator();
        double resultAdd = calculator.Add(3, 4);
        double resultSub = calculator.Subtract(10, 4);
        double resultMul = calculator.Multiply(2, 5);
        double resultDiv = calculator.Divide(20, 4);

        Console.WriteLine($"Addition: {resultAdd}");
        Console.WriteLine($"Subtraction: {resultSub}");
        Console.WriteLine($"Multiplication: {resultMul}");
        Console.WriteLine($"Division: {resultDiv}");
    }
}
