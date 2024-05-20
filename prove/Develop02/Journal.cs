class Journal
{
    private static string _path = "journals/";
    public static List<Entry> _entries = new List<Entry>();
    public static void add(Entry entry){
        _entries.Add(entry);
    }
    public static void remove(Entry entry){
        _entries.Remove(entry);
    }
    public static void remove(string date){
        Date comp = Date.stringToDate(date);
        remove(comp);
    }
    public static void remove(Date date){
        _entries.Remove(get_entry(date));
    }
    public static Entry get_entry(Date date){
        foreach (Entry entry in _entries){
            if (entry.getDate().equals(date)){
                return entry;
            }
        }
        return null;
    }
    public static void display(){
        foreach(Entry entry in _entries){
            Console.WriteLine($"");
            entry.print();
        }
    }
    public static void newJournal(){
        _entries = new List<Entry>();
    }
    public static void loadJournal(string file, bool merge = false){
        if(!merge) newJournal();
        using (StreamReader reader = new StreamReader($"{_path}{file}")){
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
    public static void saveJournal(string file){
        using (StreamWriter writer = new StreamWriter($"{_path}{file}")){
            foreach(Entry entry in _entries){
                writer.WriteLine($"{entry.getDate()}");
                int char_max = 50;
                int char_count = 0;
                foreach(char x in entry.getParagraph()){
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
    public static string giveMePrompt(){
        List<string> prompts = new List<string>(){"Did anything unexpected happen today", "What did you have planned and how did it go", "What was the best thing that happened", "What was the worst thing that happened", "What would you have done differently"};
        string prompt = prompts[new Random().Next(prompts.Count)];
        Console.WriteLine($"{prompt}");
        return prompt;
    }
}