using System;

public class MathAssignment : Assignment 
{
    private string _TextBookSection ;
    private string _problems;


    public MathAssignment(string StudentName, string topic, string TextBookSection, string problems)    
        :base(StudentName, topic)
    {
        _TextBookSection = TextBookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"Section {_TextBookSection} Problems {_problems}";
    }
} 