namespace WebApplication1.Models
{
    public class Groups
    {
        public int GroupsId { get; set; }
        public string? GroupName { get; set; }
        public string? GroupSpecialization { get; set; }
        public DateTime GroupYear { get; set; }
        public bool GroupIsExist { get; set; }
    }
}
