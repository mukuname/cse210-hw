using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Electrical Engineer";
        job1._company = "Schneider";
        job1._startYear = 2027;
        job1._endYear = 2030;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Siemens";
        job2._startYear = 2030;
        job2._endYear = 2033;

        Resume myResume = new Resume();
        myResume._name = "Enock Mukuna";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}