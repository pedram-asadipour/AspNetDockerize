using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentManager.Models;

namespace StudentManager.Pages
{
    public class IndexModel : PageModel
    {
        public Student? Student { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost([FromForm] Student student)
        {
            if (!ModelState.IsValid)
            {
                Student = student;
                return Page();
            }

            return RedirectToPage("StudentDetail", student) ;
        }
    }
}