using System;

class Assignment
{
    // Protected members so derived classes can access them
    protected string _studentName;
    protected string _topic;

    // Constructor to initialize common attributes
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method to return assignment summary
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
