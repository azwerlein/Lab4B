using SQLite;

namespace Mod3LabB;

public class QuestionRepository
{
    
    private SQLiteConnection _connection;
    private string _filePath = Path.Combine(FileSystem.AppDataDirectory, "questions.db3");

    public QuestionRepository()
    {
        Init();
    }

    private void Init()
    {
        if (_connection != null)
        {
            return;
        }
        _connection = new SQLiteConnection(_filePath);
        _connection.DropTable<Question>();
        _connection.CreateTable<Question>();
        InitQuestions();
    }

    private void InitQuestions()
    {
        AddQuestion(MakeQuestion("Do you like to run?", 1, "running"));
        AddQuestion(MakeQuestion("Do you like to swim?", 1, "swimming"));
        AddQuestion(MakeQuestion("Do you work out?", 2, "workingout"));
        AddQuestion(MakeQuestion("Do ride a bike?", 2, "biking"));
    }

    private Question MakeQuestion(string prompt, int score, string img)
    {
        Question question = new Question();
        question.QuestionText = prompt;
        question.Score = score;
        question.Image = img;
        return question;
    }

    public int AddQuestion(Question question)
    {
        int result = _connection.Insert(question);
        return result;
    }

    public List<Question> GetAllQuestions()
    {
        List<Question> questions = _connection.Table<Question>().ToList();
        return questions;
    }
}