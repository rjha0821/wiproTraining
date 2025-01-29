// See https://aka.ms/new-console-template for more information
using System;
namespace Program
{
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
}
