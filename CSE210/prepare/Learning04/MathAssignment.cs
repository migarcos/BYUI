public class MathAssignment : Assignment
{
    private string _textBook = "";
    private string _problems = "";
    // CONSTRUCTORS
    public MathAssignment()
    {     
        _textBook = "BookUnknow";
        _problems = "NoProblems";
    }
    public MathAssignment(string studentName, string topic, string textBook, string problems): base(studentName, topic)
    {   
        // SetStudent(studentName);    No needed because I use  :base
        // _topic = topic;     No needed because I use  :base
        _textBook = textBook;
        _problems = problems;
    }
    // METHODS
    public string GetHomeworkList()
    {
        return $"{_studentName} - {_topic}: {_textBook}, {_problems}";
    }
}