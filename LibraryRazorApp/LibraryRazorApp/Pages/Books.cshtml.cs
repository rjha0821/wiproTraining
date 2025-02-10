using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class BooksModel : PageModel
{
    public List<string> Books { get; set; } = new() { "Book 1", "Book 2", "Book 3" };
}
