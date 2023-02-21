using IssueModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Test.Pages.Issues
{
    public class IssueOverviewModel : PageModel
    {
        public List<IssuesOverview> activeIssues { get; set; } = new List<IssuesOverview>();
        public void OnGet()
        {
            activeIssues = new List<IssuesOverview>();
        }

    }
}
