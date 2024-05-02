
using SQLite;

namespace Mod3LabB
{
    [Table("question")]
    public class Question
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        [MaxLength(200), Unique]
        public string QuestionText { get; set; }
        [Unique]
        public int Score { get; set; }
        [MaxLength(50), Unique]
        public string Image { get; set; }
        
    }
}
