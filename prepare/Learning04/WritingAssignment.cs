using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string StudentName, string topic, string title)
        :base(StudentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string StudentName = GetStudentName();

        return $"{_title} by {StudentName}";
    }
}
