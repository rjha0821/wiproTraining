using System;
using System.Collections.Generic;

public class AuthenticationService
{
    private static readonly Dictionary<string, User> users = new Dictionary<string, User>();

    public static void Register(string username, string password)
    {
        if (users.ContainsKey(username))
        {
            LoggingService.LogError($"Registration failed: {username} already exists.");
            throw new Exception("User already exists.");
        }

        users[username] = new User(username, password);
        LoggingService.LogInfo($"User registered: {username}");
        Console.WriteLine("Registration successful.");
    }

    public static void Login(string username, string password)
    {
        if (users.TryGetValue(username, out User user) && user.VerifyPassword(password))
        {
            LoggingService.LogInfo($"User logged in: {username}");
            Console.WriteLine("Login successful.");
        }
        else
        {
            LoggingService.LogError($"Login failed: {username}");
            throw new Exception("Invalid username or password.");
        }
    }
}
