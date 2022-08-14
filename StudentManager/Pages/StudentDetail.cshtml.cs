using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentManager.Models;

namespace StudentManager.Pages
{
    public class StudentDetailModel : PageModel
    {
        public Student Student { get; set; }
        public IActionResult OnGet(Student student)
        {
            if (student == null)
                return NotFound();

            Student = student;

            return Page();
        }
    }
}
