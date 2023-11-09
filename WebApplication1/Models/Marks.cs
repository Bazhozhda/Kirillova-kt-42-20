using System.Text.RegularExpressions;

namespace WebApplication1.Models
{
    public class Marks
    {
        public int MarksId { get; set; }
        public int StudentsId {  get; set; }
        public Students? Students { get; set; }
        public int DisciplinesId { get; set; }
        public Disciplines? Disciplines { get; set; }
        public int MarkValue { get; set; }
    }
}
