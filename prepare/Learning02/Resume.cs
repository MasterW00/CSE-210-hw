class Resume
{
    private string name;
    private List<Job> jobs;
    public static bool alternateDisplay = false;
    public Resume(string name, List<Job> jobs){
        this.jobs = jobs;
        this.name = name;
    }
    public void Display(){
        if(alternateDisplay){
            Console.WriteLine($"Hello, I'm {name}");
            Console.WriteLine($"This is my job history:");
            foreach(Job job in jobs){
                job.Display();
            }
        }
        else{
            Console.WriteLine($"Name: {name}\nJobs:");
            foreach (Job job in jobs){
                job.Display();
            }
        }
    }
}