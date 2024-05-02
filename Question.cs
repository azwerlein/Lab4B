
using SQLite;

namespace Mod3LabB
{
    [Table("question")]
    public class Question
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(200)]
        public string QuestionText { get; set; }
        public int Score { get; set; }
        [MaxLength(50)]
        public string Image { get; set; }
        
    }
}
