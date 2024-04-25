
namespace Mod3LabB
{
    public class Question
    {
        public string QuestionText { get; set; }
        public int Score { get; set; }
        public string Image { get; set; }
        public Question(string questionText, int score, string image) 
        {
            QuestionText = questionText;
            Score = score;
            Image = image;
        }
    }
}
