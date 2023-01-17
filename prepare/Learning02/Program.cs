using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Tickles";
        job1._jobTitle = "TickleMonster";
        job1._startYear = 1976;
        job1._endYear = 1999;

        Job job2 = new Job();
        job2._company = "PeekaBooer";
        job2._jobTitle = "There you are!";
        job2._startYear = 2076;
        job2._endYear = 3000;

        Job job3 = new Job();
        job3._company = "Feeding Time";
        job3._jobTitle = "Here comes the Choo Choo!";
        job3._startYear = 5000;
        job3._endYear = 6000;

        Resume myResume = new Resume();
        myResume._name = "Thomas Johnson";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.DisplayJobStuff();

    }
}