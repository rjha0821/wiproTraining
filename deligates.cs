using System;

class Program{

    // public delegate void addNumber(int a, int b);
    // public delegate void subNumber(int a, int b);

    // public void sum(int a, int b){
    //     Console.WriteLine("(100 + 60) = {0}", a + b);
    // }

    // public void sub(int a, int b){
    //     Console.WriteLine("(100 - 40) = {0}", a - b);
    // }

    public delegate int addNumber(int a, int b);
    public delegate int subNumber(int a, int b);
    public int sum(int a, int b){
        return a + b;
    }

    public int sub(int a, int b){
        return a - b;
    }



    public static void Main(String[] args){
        Program pgm = new Program();

        addNumber delObj1 = new addNumber(pgm.sum);
        subNumber delObj2 = new subNumber(pgm.sub); 

        // delObj1(100,60);
        // delObj2(100,40);
        Console.WriteLine("Sum " + delObj1(100,60));
        Console.WriteLine("Sub " + delObj2(100,40));


    }
}

Program.Main(null);