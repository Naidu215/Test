using IssueModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Test.Pages.Issues
{
    public class AddNewIssueModel : PageModel
    {
        public IssuesOverview addNewIssue { get; set; } = new IssuesOverview();
        public void OnGet()
        {
            addNewIssue = new IssuesOverview();
        }

        public IActionResult OnPost(IssuesOverview addNewIssue) 
        {
            if (!ModelState.IsValid) return Page();


            return RedirectToPage("/Issues/IssueOverview");
        }
    }
}
