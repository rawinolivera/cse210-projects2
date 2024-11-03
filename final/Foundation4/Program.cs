using System;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity running = new RunningActivity(10, "Running", "10 May 2024", 4);
        CyclingActivity cycling = new CyclingActivity(25, "Cycling", "08 Jun 2024", 40);
        SwimmingActivity swimming = new SwimmingActivity(5, "Swimming", "04 Oct 2024", 10);

        running.Summary();
        cycling.Summary();
        swimming.Summary();
    }
}

//RunningActivity(float distance, string name, string date, int length)