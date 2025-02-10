using System;
using LibraryManagement.Models;

class Program
{
    static void Main()
    {
        Library library = new Library();

        // Adding Books
        library.AddBook(new Book("C# Basics", "John Doe", "ISBN123"));
        library.AddBook(new Book("Advanced C#", "Jane Smith", "ISBN456"));

        // Registering Borrowers
        library.RegisterBorrower(new Borrower("Alice", "CARD001"));
        library.RegisterBorrower(new Borrower("Bob", "CARD002"));

        // Borrowing a Book
        library.BorrowBook("ISBN123", "CARD001");

        // Viewing Books & Borrowers
        library.ViewBooks();
        library.ViewBorrowers();

        // Returning a Book
        library.ReturnBook("ISBN123", "CARD001");

        // Viewing Books & Borrowers after return
        library.ViewBooks();
        library.ViewBorrowers();
    }
}
