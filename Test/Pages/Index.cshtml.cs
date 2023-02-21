using IssueModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Test.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public Credentials credentials { get; set; } = new Credentials();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            credentials = new Credentials();

        }

        public IActionResult OnPost(Credentials credentials)
        {
            if (!ModelState.IsValid) return Page();


            return RedirectToPage("/Issues/IssueOverview");
        }
        
    }
}