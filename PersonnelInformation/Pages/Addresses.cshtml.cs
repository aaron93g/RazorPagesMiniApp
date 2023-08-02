using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PersonnelInformation.Pages
{
    public class AddressesModel : PageModel
    {
        [BindProperty]
        public string Street { get; set; } = string.Empty;
        [BindProperty]
        public string City { get; set; } =string.Empty;
        [BindProperty]
        public string State { get; set; }
        [BindProperty]
        public string ZipCode { get; set; }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string FullAddress => $"{Street} {City}, {State} {ZipCode} \n {Email}";

        [BindProperty]
        public List<string> AddressList { get; set; } = new List<string>();


        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            AddressList.Add(FullAddress);
            return Page();
        }
    }
}
