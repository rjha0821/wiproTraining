using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class AddBookModel : PageModel
{
    [BindProperty]
    public string NewBook { get; set; } = "";

    public IActionResult OnPost()
    {
        if (!string.IsNullOrEmpty(NewBook))
        {
            TempData["Message"] = $"Book '{NewBook}' added!";
            return RedirectToPage("Books");
        }
        return Page();
    }
}
