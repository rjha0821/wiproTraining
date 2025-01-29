
// string a = "bye";
// Console.WriteLine("Enter something :");
// string b = Console.ReadLine();
// Console.WriteLine($"Hello {a} world! {b}" );

// Console.WriteLine($"Hello Enter Number" );
// int c = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("No is {0}",c );

// int ? d = null;
// int e = d ?? 20;


// Day2
// Prompt the user to enter the first number
// Console.WriteLine("Enter the first number:");
// int num1;
// while (!int.TryParse(Console.ReadLine(), out num1))
// {
//     Console.WriteLine("Invalid input. Please enter a valid integer:");
// }

// // Prompt the user to enter the second number
// Console.WriteLine("Enter the second number:");
// int num2;
// while (!int.TryParse(Console.ReadLine(), out num2))
// {
//     Console.WriteLine("Invalid input. Please enter a valid integer:");
// }



// int sum = num1 + num2;
// int difference = num2 - num1;
// int product = num1 * num2;


// // Print the results
// Console.WriteLine("The sum is: " + sum);
// Console.WriteLine("The difference is: " + difference);
// Console.WriteLine("The product is: " + product);
// if (num2 != 0)
// {
//     int quotient = num2 / num1;
//     Console.WriteLine("The quotient is: " + quotient);
// }
// else
// {
//     Console.WriteLine("Error: Division by zero is not allowed.");
// }

//day2

// using System.Text;

// String a = "HEY";
// Console.WriteLine("Enter word want to append ");
// String b = Console.ReadLine();

// a = a+" "+b;
// Console.WriteLine(a);

// StringBuilder s = new StringBuilder();

// s.Append(a);

// Console.WriteLine(s);

//Array

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] a = new int[5];

        for (int i = 0; i < a.Length; i++)
        {
            Console.Write("Enter Number want to insert: ");
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        PrintArray(a);
    }

    public static void PrintArray(int[] a)
    {
        foreach (int val in a)
        {
            Console.WriteLine("Your Entered Value is: " + val);
        }
    }
}

// Call Main explicitly when running as a script
Program.Main(null);

