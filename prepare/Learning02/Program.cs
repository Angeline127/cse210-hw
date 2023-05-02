using System;

using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle="Computer Programmer";
        job1._company="Apple";
        job1._startYear=2017;
        job1._endYear=2019;

        Job job2 = new Job();
        job2._jobTitle="Lawyer";
        job2._company="International Justice";
        job2._startYear=2020;
        job2._endYear=2023;

        Resume myResume = new Resume();
        myResume._Name = "Angeline Nyepen";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        

        myResume.Display();
    }
}