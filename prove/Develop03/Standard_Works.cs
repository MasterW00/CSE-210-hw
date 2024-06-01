public class Standard_Works
{
    private static List<string> _books = new List<string>(){"BookOfMormon", "NewTestament", "DoctrineAndCovenants", "OldTestament", "PearlOfGreatPrice"};
    protected static string _file = "Standard_Works/";
    public static StreamReader findBook(Scripture verse){
        StreamReader read = verse.openScripture();
        int num = 0;
        string book = MakeBookTitleCase(verse.getBook());
        verse.setBook(book);
        while(true){
            num++;
            string line = read.ReadLine();
            if(line == null) return null;
            if(line.Contains('$') && line.Contains(book)){
                verse.setBookLine(num);
                return read;
            }
        }
    }
    public static StreamReader findChapter(Scripture verse){
        StreamReader read = findBook(verse);
        int num = 0;
        while(true){
            num++;
            string line = read.ReadLine();
            if(line == null) return null;
            if(line.Contains('%') && line.Contains($"{verse.getChapter()}")){
                verse.setChapterLine(num);
                return read;
            }
        }   
    }
    public static StreamReader findVerse(Scripture verse){
        if(verse.getText() != null) return null;
        StreamReader read = findChapter(verse);
        int x = 0;
        string line = null;
        while(x < verse.getVerse()){
            try {line = read.ReadLine();}
            catch (NullReferenceException){
                Console.WriteLine($"Scripture is not part of the standard works.\nFor now type what it says below");
                verse.setText(Console.ReadLine());
                return null;
            }
            if(line.Contains('%') || line.Contains('$')){
                Console.WriteLine($"Scripture is not part of the standard works.\nFor now type what it says below");
                verse.setText(Console.ReadLine());
                return null;
            }
            x++;
        }
        verse.setVerseLine(x);
        if(verse.getEndVerse() != -1){
            while(x < verse.getEndVerse()){
                line = $"{line}\n\n{read.ReadLine()}";
                x++;    
            }
            verse.setEndVerseLine(x);
        }
        verse.setText(line);
        Console.WriteLine($"{x}");
        return read;
    }
    static string MakeBookTitleCase(string book){
        string a = book.ToLower();
        a = book.Substring(0, 1).ToUpper() + book.Substring(1);
        return a;
    }
}