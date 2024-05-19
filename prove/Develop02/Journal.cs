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
        foreach (Entry entry in entries){
            if (entry.get_date().equals(comp)){
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
    public static void load_journal(string file){
        newJournal();
        using (StreamReader reader = new StreamReader($"{path}{file}")){
            string line;
            while((line = reader.ReadLine()) != null){
                Date date = Date.stringToDate(line);
                string paragraph = "";
                while((line = reader.ReadLine()) != ""){
                    if (line == null) break;
                    paragraph = paragraph + line + "\n";
                }
                Journal.add(new Entry(date, paragraph));
            }
        }
    }
    public static void save_journal(string file){
        using (StreamWriter writer = new StreamWriter($"{path}{file}")){
            foreach(Entry entry in entries){
                writer.WriteLine(entry.get_date().toString());
                writer.WriteLine(entry.get_paragraph());
            }
        }

    }
}