public class Assignment
{
    protected string _studentName = "";
    protected string _topic = "";
    // Constructors
    public Assignment()
    {
        _studentName = "Anonymous";
        _topic = "Unknown";
    }
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    // Setters and Getters
    public void SetStudent(string name)
    {
        _studentName = name;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }
    public string GetStudentName()
    {
        return "${_studentName}";
    }
    public string GetTopic()
    {
        return "$ {_topic}";
    }
    // Methods
    public void setAssignment(string name, string topic){
        SetStudent(name);
        SetTopic(topic);
    }
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}