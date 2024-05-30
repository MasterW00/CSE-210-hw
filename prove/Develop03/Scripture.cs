public class Scripture:Standard_Works{
    private string work;
    private string book;
    private int chapter;
    private int verse;
    private int endverse = -1;
    private int book_line = -1;
    private int chapter_line  = -1;
    private int verse_line = -1;
    private  int endverse_line = -1;
    private string text = null;
    public Scripture(string work, string book, int chapter, int verse){
        this.work = work;
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
        if(text == null) Standard_Works.findVerse(this);
    }
    public Scripture(string work, string book, int chapter, int verse, int endverse){
        this.work = work;
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
        this.endverse = endverse;
    }
    public Scripture(string work, string book, int chapter, int verse, string text){
        this.work = work;
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
        this.text = text;
    }
    public Scripture(string work, string book, int chapter, int verse, int endverse, string text){
        this.work = work;
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
        this.endverse = endverse;
        this.text = text;
    }
    public string getBook(){
        return book;
    }
    public string getWork(){
        return work;
    }
    public int getChapter(){
        return chapter;
    }
    public int getVerse(){
        return verse;
    }
    public int getEndVerse(){
        return endverse;
    }
    public int getBookLine(){
        return book_line;
    }
    public int getChapterLine(){
        return chapter_line;
    }
    public int getVerseLine(){
        return verse_line;
    }
    public string getText(){
        return text;
    }
    public void setBookLine(int book_line){
        this.book_line = book_line;
    }
    public void setChapterLine(int chapter_line){
        this.chapter_line = chapter_line;
    }
    public void setVerseLine(int verse_line){
        this.verse_line = verse_line;
    }
    public void setEndVerseLine(int endverse_line){
        this.endverse_line = endverse_line;
    }
    public void setText(string text){
        this.text = text;
    }
    public StreamReader openScripture(){
        return new StreamReader($"{Standard_Works.file}{work}.txt");
    }
    public string getReference(){
        string refr = $"{book} {chapter}:{verse}";
        if(endverse!= -1) refr = $"{refr}-{endverse}";
        return refr;
    }
    public void printScripture(){
        Console.Clear();
        Console.WriteLine($"{getReference()}");
        Console.WriteLine($"{getText()}\n");
    }
}