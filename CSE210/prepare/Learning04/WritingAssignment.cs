public class WritingAssignment : Assignment
{
    private string _title = "";
    // CONSTRUCTORS
    public WritingAssignment()
    {
        _title = "Without Title";
    }
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;       
    }
    // Setters and Getters
    // METHODS
    public string GetWritingInformation()
    {
        return $"{_studentName} - {_topic} : {_title}";
    }
}