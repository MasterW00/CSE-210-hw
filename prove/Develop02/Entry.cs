using System;

class Entry
{
    private Date _date;
    private string _paragraph;
    public Entry(Date date, string paragraph){
        _date = date;
        _paragraph = paragraph;
    }
    public void editParagraph(string newparagraph){
        _paragraph = newparagraph;
    }
    public string getParagraph(){
        return _paragraph;
    }
    public Date getDate(){
        return _date;
    }
    public void print(){
        this._date.print();
        Console.WriteLine(_paragraph);
    }
}