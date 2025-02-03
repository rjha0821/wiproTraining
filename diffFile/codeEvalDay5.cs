using System;

// Define PropertyDemo class
public class PropertyDemo
{
    // Define properties
    // Complete Step 1:............
   private int value;
   public PropertyDemo(int i){
       value = i;
       Console.WriteLine(value);
       Console.WriteLine("Private Value");
       Console.WriteLine("Static Constructor");
   }
}

// Define StaticDemo class
public class StaticDemo
{
    // Define static members
    // Complete Step 2:............
    static int value;
    public static void setValue(int i){
        value = i;
        Console.WriteLine(value);
        Console.WriteLine("Static Method");
    }
}

// Define MathHelper static class
public static class MathHelper
{
    // Define static methods
    // Complete Step 3:............
    
    public static int Sum(int a, int b){
        return a+b;
    }
    public static int Sub(int a, int b){
        return b-a;
    }
}

public class Program
{
    public static void Main()
    {
        // Demonstrate usage
        // Complete Step 4:............
        int propertyValue = Convert.ToInt32(Console.ReadLine());
        PropertyDemo demo = new PropertyDemo(propertyValue);

        int staticValue = Convert.ToInt32(Console.ReadLine());
        StaticDemo.setValue(staticValue);

        Console.WriteLine(MathHelper.Sum(propertyValue, staticValue));
        Console.WriteLine(MathHelper.Sub(propertyValue, staticValue));
    }
}

Program.Main();