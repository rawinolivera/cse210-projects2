using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Anka";
        job1._jobTitle = "Assistent";
        job1._startYear = 2016;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Bloom";
        job2._jobTitle = "Mentor";
        job2._startYear = 2022;
        job2._endYear = 2022;

        Resume resume1 = new Resume();
        resume1._name = "Rawin Olivera";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.DisplayResume();

    }
}