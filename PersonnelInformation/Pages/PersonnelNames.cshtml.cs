using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PersonnelInformation.Pages
{
    public class PersonnelNamesModel : PageModel
    {
        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }

        [BindProperty]
        public string FullName => $"{FirstName} {LastName}";

        [BindProperty]
        public List<string> Names { get; set; } = new List<string>();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Names.Add(FullName);
            return Page();
        }
    }
}
