// using System;

// class Program{

//     // public delegate void addNumber(int a, int b);
//     // public delegate void subNumber(int a, int b);

//     // public void sum(int a, int b){
//     //     Console.WriteLine("(100 + 60) = {0}", a + b);
//     // }

//     // public void sub(int a, int b){
//     //     Console.WriteLine("(100 - 40) = {0}", a - b);
//     // }

//     public delegate int addNumber(int a, int b);
//     public delegate int subNumber(int a, int b);
//     public int sum(int a, int b){
//         return a + b;
//     }

//     public int sub(int a, int b){
//         return a - b;
//     }



//     public static void Main(String[] args){
//         Program pgm = new Program();

//         addNumber delObj1 = new addNumber(pgm.sum);
//         subNumber delObj2 = new subNumber(pgm.sub); 

//         // delObj1(100,60);
//         // delObj2(100,40);
//         Console.WriteLine("Sum " + delObj1(100,60));
//         Console.WriteLine("Sub " + delObj2(100,40));


//     }
// }

// Program.Main(null);


// C# program to illustrate the 
// Multicasting of Delegates
using System;

class rectangle
{
    public delegate void rectDelegate(double height, double width);

    public void area(double height, double width)
    {
        Console.WriteLine("Area is: {0}", (width * height));
    }

    public void perimeter(double height, double width)
    {
        Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
    }


    public static void Main(String[] args)
    {

        rectangle rect = new rectangle();
        
        // these two lines are normal calling
        // of that two methods
        // rect.area(6.3, 4.2);
        // rect.perimeter(6.3, 4.2);

        // creating delegate object, name as "rectdele"
        // and pass the method as parameter by 
        // class object "rect"
            
        rectDelegate rectdele = new rectDelegate(rect.area);
        // also can be written as 
        // rectDelegate rectdele = rect.area;

        // call 2nd method "perimeter"
        // Multicasting
        rectdele += rect.perimeter;

        // pass the values in two method 
        // by using "Invoke" method
        rectdele.Invoke(6.3, 4.2);
        Console.WriteLine();

        rectdele.Invoke(16.3, 10.3);
    }
}

rectangle.Main(null);