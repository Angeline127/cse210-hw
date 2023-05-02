using System;
// A code template for the category of things known as JOB. The
// responsibility of a JOB is to hold and display personal information.
public class Job{

    // The C# convention is to start member variables with an underscore _
    
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear ;

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
  

    // A method that displays the person's job information a
    // give as an example in the format "Job Title (Company) StartYear-EndYear",
    // for example: "Software Engineer (Microsoft) 2019-2022". 
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}