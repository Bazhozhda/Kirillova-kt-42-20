namespace WebApplication1.Models
{
    public class CreditMarks
    {
        public int CreditMarksId { get; set; }
        public int StudentsId { get; set; }
        public Students? Students { get; set; }
        public int DisciplinesId { get; set; }
        public Disciplines? Disciplines { get; set; }
        public bool IsGotCredit { get; set; }
    }
}
