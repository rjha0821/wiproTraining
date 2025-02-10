using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement.Models
{
    public class Library
    {
        public List<Book> Books { get; private set; } = new List<Book>();
        public List<Borrower> Borrowers { get; private set; } = new List<Borrower>();

        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"Book '{book.Title}' added successfully.");
        }

        public void RegisterBorrower(Borrower borrower)
        {
            Borrowers.Add(borrower);
            Console.WriteLine($"Borrower '{borrower.Name}' registered successfully.");
        }

        public void BorrowBook(string isbn, string libraryCardNumber)
        {
            var book = Books.FirstOrDefault(b => b.ISBN == isbn);
            var borrower = Borrowers.FirstOrDefault(b => b.LibraryCardNumber == libraryCardNumber);

            if (book == null || borrower == null || book.IsBorrowed)
            {
                Console.WriteLine("Cannot borrow book. Either book or borrower not found, or book is already borrowed.");
                return;
            }

            borrower.BorrowBook(book);
            Console.WriteLine($"Book '{book.Title}' borrowed by {borrower.Name}.");
        }

        public void ReturnBook(string isbn, string libraryCardNumber)
        {
            var borrower = Borrowers.FirstOrDefault(b => b.LibraryCardNumber == libraryCardNumber);
            var book = borrower?.BorrowedBooks.FirstOrDefault(b => b.ISBN == isbn);

            if (book == null)
            {
                Console.WriteLine("Book not found in borrower's record.");
                return;
            }

            borrower.ReturnBook(book);
            Console.WriteLine($"Book '{book.Title}' returned by {borrower.Name}.");
        }

        public void ViewBooks()
        {
            Console.WriteLine("\nLibrary Books:");
            foreach (var book in Books)
            {
                Console.WriteLine($"- {book.Title} by {book.Author} (ISBN: {book.ISBN}) - {(book.IsBorrowed ? "Borrowed" : "Available")}");
            }
        }

        public void ViewBorrowers()
        {
            Console.WriteLine("\nBorrowers List:");
            foreach (var borrower in Borrowers)
            {
                Console.WriteLine($"- {borrower.Name} (Card: {borrower.LibraryCardNumber}) - Books Borrowed: {borrower.BorrowedBooks.Count}");
            }
        }
    }
}
