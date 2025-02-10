using System.Collections.Generic;

namespace LibraryManagement.Models
{
    public class Borrower
    {
        public string Name { get; set; }
        public string LibraryCardNumber { get; set; }
        public List<Book> BorrowedBooks { get; set; } = new List<Book>();

        public Borrower(string name, string libraryCardNumber)
        {
            Name = name;
            LibraryCardNumber = libraryCardNumber;
        }

        public void BorrowBook(Book book)
        {
            BorrowedBooks.Add(book);
            book.Borrow();
        }

        public void ReturnBook(Book book)
        {
            BorrowedBooks.Remove(book);
            book.Return();
        }
    }
}
