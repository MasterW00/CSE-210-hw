class Job
{
    private string title;
    
    private string company;
    private int yearStart;
    private int yearEnd;
    public static bool alternateDisplay = false;
    public Job(string title, string company, int yearStart, int yearEnd){
        this.title = title;
        this.company = company;
        this.yearStart = yearStart;
        this.yearEnd = yearEnd;
    }
    public void Display(){
        if(alternateDisplay){
            Console.WriteLine($"[{company}] {title}, {yearStart} - {yearEnd}");
        }
        else{
            Console.WriteLine($"{title} ({company}) {yearStart} - {yearEnd}");
        }
    }

}