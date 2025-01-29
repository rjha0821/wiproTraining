// using System;

// public class Program{
//     public static void Main(string[] args){
//         Console.WriteLine("Enter team member strength ");
//         int size = Convert.ToInt32(Console.ReadLine());
//         int[][] a = new int[size][];

//         for(int i = 0; i<size; i++){
//             Console.Write($"Enter rounds {i+1} team ");
//             int member = Convert.ToInt32(Console.ReadLine());

//             a[i] = new int[member];
//             for(int j=0; j<member; j++){
//                 Console.Write("Enter team member score {0} ",i+1);
//                 a[i][j] = Convert.ToInt32(Console.ReadLine());
//             }
//         }
        

//             for(int i=0; i<a.Length; i++){
//                 int sum = 0;
//                 for(int j=0; j<a[i].Length; j++){
//                     Console.WriteLine($"Score of team {i+1} {a[i][j]} ");
//                     sum = sum+a[i][j];
//                 }
//                 Console.WriteLine($"Sum of {i+1} {sum}");
//             }
//     }

// }

// Program.Main(null);


//Multidimesion Array
using System;

public class Program{
    public static void Main(string[] args){
        Console.Write("Enter Row ");
        int row = int.Parse(Console.ReadLine());
        Console.Write("Enter column ");
        int column = int.Parse(Console.ReadLine()); 

        int [,] a = new int [row,column];

        for(int i=0; i<row; i++){
            for(int j=0; j<column;j++){
                Console.Write($"Elemnet {i} {j} ");
                a[i,j] = int.Parse(Console.ReadLine());
            }
        }
        
        for(int i=0; i<row; i++){
            for(int j=0; j<column;j++){
                Console.Write($"{a[i,j]} ");
                
            }
            Console.WriteLine();
        }
    }

}

Program.Main(null);