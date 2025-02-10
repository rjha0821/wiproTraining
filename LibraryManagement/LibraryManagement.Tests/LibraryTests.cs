using NUnit.Framework; // ✅ Keep this
using LibraryManagement.Models;



namespace LibraryManagement.Tests
{
    public class LibraryTests
    {
        [Test]
        public void Test_AddBook()
        {
            Library library = new Library();
            Book book = new Book("Test Book", "Test Author", "ISBN999");
            library.AddBook(book);

            NUnit.Framework.Assert.That(library.Books.Contains(book)); // ✅ Explicitly specify NUnit
        }

        [Test]
        public void Test_RegisterBorrower()
        {
            Library library = new Library();
            Borrower borrower = new Borrower("Test User", "CARD999");
            library.RegisterBorrower(borrower);

            NUnit.Framework.Assert.That(library.Borrowers.Contains(borrower)); // ✅ Explicitly specify NUnit
        }
    }
}
