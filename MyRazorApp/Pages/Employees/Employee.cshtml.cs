using Microsoft.AspNetCore.Mvc.RazorPages;
using MyRazorApp.Models;  // Import the Models namespace

namespace MyRazorApp.Pages.Employees 
{
    public class EmployeeModel : PageModel  
    {
        public List<Employee> Employees { get; set; } = new();

        public void OnGet()
        {
            Employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice", Position = "Manager", Salary = 75000 },
                new Employee { Id = 2, Name = "Bob", Position = "Developer", Salary = 60000 },
                new Employee { Id = 3, Name = "Charlie", Position = "Designer", Salary = 55000 }
            };
        }
    }
}
