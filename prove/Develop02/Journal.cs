class Journal
{
    private static string path = "journals/";
    public static List<Entry> entries = new List<Entry>();
    public static void add(Entry entry){
        entries.Add(entry);
    }
    public static void Remove(Entry entry){
        entries.Remove(entry);
    }
    public static void Remove(string date){
        Date comp = Date.stringToDate(date);
        Remove(date);
    }
    public static void Remove(Date date){
        foreach (Entry entry in entries){
            if (entry.get_date().equals(date)){
                entries.Remove(entry);
                break;
            }
        }
    }
    public static void Display(){
        foreach(Entry entry in entries){
            Console.WriteLine($"");
            entry.print();
        }
    }
    public static void newJournal(){
        entries = new List<Entry>();
    }
    public static void load_journal(string file, bool merge = false){
        if(!merge) newJournal();
        using (StreamReader reader = new StreamReader($"{path}{file}")){
            string line;
            while((line = reader.ReadLine()) != null){
                Date date = Date.stringToDate(line);
                string paragraph = "";
                while((line = reader.ReadLine()) != "" && line != null){
                    paragraph = paragraph + line + "\n";
                }
                add(new Entry(date, paragraph)); 
            }
        }
    }
    public static void save_journal(string file){
        using (StreamWriter writer = new StreamWriter($"{path}{file}")){
            foreach(Entry entry in entries){
                writer.WriteLine(entry.get_date().toString());
                int char_max = 50;
                int char_count = 0;
                foreach(char x in entry.get_paragraph()){
                    if(x == '\n') continue;
                    writer.Write(x);
                    char_count++;
                    if(char_max <= char_count && x == ' '){
                            char_count = 0;
                            writer.WriteLine();
                    }
                }
                writer.WriteLine();
                writer.WriteLine();
            }
        }
    }
    public static string give_me_a_prompt(){
        List<string> prompts = new List<string>(){"Did anything unexpected happen today", "What did you have planned and how did it go", "What was the best thing that happened", "What was the worst thing that happened", "What would you have done differently"};
        string prompt = prompts[new Random().Next(prompts.Count)];
        Console.WriteLine($"{prompt}");
        return prompt;
    }
}