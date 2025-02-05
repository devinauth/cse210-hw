using System;

class MathAssignment : Assignment
{
    // Additional properties for math assignments
    private string _textbookSection;
    private string _problems;

    // Constructor - Calls the base class constructor
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) 
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Method to return homework details
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
