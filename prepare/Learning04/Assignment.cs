using System;

public class Assignment 
{
    private string _StudentName;
    private string  _topic;


    public Assignment(string StudentName, string topic)
    {
        _StudentName = StudentName;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _StudentName;
    }

    public string GetStudentTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _StudentName + " - " + _topic;
    }
}