using System.ComponentModel.DataAnnotations;

namespace IssueModel
{
    public class IssuesOverview
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(250)]
        public string Description { get; set; } = string.Empty;

        public IssueType Issue { get; set; }

        public Priority Priority { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Completed { get; set; }
    }
}
