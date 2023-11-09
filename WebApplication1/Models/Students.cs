using System.Text.RegularExpressions;

namespace WebApplication1.Models
{
    public class Students
    {
        public int StudentsId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
        public int GroupsId { get; set; }
        public Groups? Groups { get; set; }
        public bool StudentIsExist { get; set; }
    }
}
