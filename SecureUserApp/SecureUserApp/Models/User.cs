using System;
using System.Security.Cryptography;
using System.Text;

public class User
{
    public string Username { get; set; }
    public string HashedPassword { get; private set; }

    public User(string username, string password)
    {
        Username = username;
        HashedPassword = HashPassword(password);
    }

    // Secure password hashing using SHA-256
    private static string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return BitConverter.ToString(bytes).Replace("-", "").ToLower();
        }
    }

    // Verify password
    public bool VerifyPassword(string password)
    {
        return HashedPassword == HashPassword(password);
    }
}
