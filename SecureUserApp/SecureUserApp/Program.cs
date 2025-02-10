using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("1. Register\n2. Login");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (choice == 1)
            {
                AuthenticationService.Register(username, password);
            }
            else if (choice == 2)
            {
                AuthenticationService.Login(username, password);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
        catch (Exception ex)
        {
            LoggingService.LogError($"Error: {ex.Message}");
            Console.WriteLine("An error occurred. Please check logs.");
        }
    }
}
