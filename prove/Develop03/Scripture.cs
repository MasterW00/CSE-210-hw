public class Scripture:Standard_Works{
    private string _work;
    private string _book;
    private int _chapter;    private int _verse;
    private int _endverse = -1;
    private int _book_line = -1;
    private int _chapter_line  = -1;
    private int _verse_line = -1;
    private  int _endverse_line = -1;
    private string _text = null;
    public Scripture(string work, string book, int chapter, int verse){
        this._work = work;
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
        if(_text == null) Standard_Works.findVerse(this);
    }
    public Scripture(string work, string book, int chapter, int verse, int endverse){
        this._work = work;
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
        this._endverse = endverse;
    }
    public Scripture(string work, string book, int chapter, int verse, string text){
        this._work = work;
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
        this._text = text;
    }
    public Scripture(string work, string book, int chapter, int verse, int endverse, string text){
        this._work = work;
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
        this._endverse = endverse;
        this._text = text;
    }
    public string getBook(){
        return _book;
    }
    public string getWork(){
        return _work;
    }
    public int getChapter(){
        return _chapter;
    }
    public int getVerse(){
        return _verse;
    }
    public int getEndVerse(){
        return _endverse;
    }
    public int getBookLine(){
        return _book_line;
    }
    public int getChapterLine(){
        return _chapter_line;
    }
    public int getVerseLine(){
        return _verse_line;
    }
    public string getText(){
        return _text;
    }
    public string setBook(string book){
        return _book = book;
    }
    public void setBookLine(int book_line){
        this._book_line = book_line;
    }
    public void setChapterLine(int chapter_line){
        this._chapter_line = chapter_line;
    }
    public void setVerseLine(int verse_line){
        this._verse_line = verse_line;
    }
    public void setEndVerseLine(int endverse_line){
        this._endverse_line = endverse_line;
    }
    public void setText(string text){
        this._text = text;
    }
    public StreamReader openScripture(){
        return new StreamReader($"{Standard_Works._file}{_work}.txt");
    }
    public string getReference(){
        string refr = $"{_book} {_chapter}:{_verse}";
        if(_endverse!= -1) refr = $"{refr}-{_endverse}";
        return refr;
    }
    public void printScripture(){
        Console.Clear();
        Console.WriteLine($"{getReference()}");
        Console.WriteLine($"{getText()}\n");
    }
}