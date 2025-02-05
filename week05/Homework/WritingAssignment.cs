using System;

class WritingAssignment : Assignment
{
    // Additional property for writing assignments
    private string _title;

    // Constructor - Calls the base class constructor
    public WritingAssignment(string studentName, string topic, string title) 
        : base(studentName, topic)
    {
        _title = title;
    }

    // Method to return writing assignment details
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}
