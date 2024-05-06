using System;

class Program
{
  static void Main(string[] args)  
    {
        Resume.alternateDisplay = false;
        Job.alternateDisplay = false;
        Job job1 = new Job("Solutions Architect", "MAPR", 2017, 2019);
        job1.Display();
        Job job2 = new Job("Data processing Engineer", "Minio", 2020, 2021);
        Console.WriteLine();
        List<Job> experiance = new List<Job>(){job1, job2};
        Resume michael = new Resume("Michael Farnbach", experiance);
        michael.Display();

    }
}